using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgrithmProj
{
    class GraphSearch<T>
    {
        struct Node
        {
            public T parent;//达到当前点的路径
            public T current;//当前点
        }

        struct PathNode
        {
            public List<T> paths;
            public int cost;
        }

        /// <summary>
        /// 狄克斯特拉
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dict">T1 父 T2 子 int T1->T2的权重  路径参照表 </param>
        /// <param name="predicate">查找条件</param>
        public static void DijkstraSearch(Dictionary<T,Dictionary<T,int>> dict,Predicate<T> predicate = null)
        {
            Queue<Node> queue = new Queue<Node>();
            Dictionary<T, PathNode> shortestCosts = new Dictionary<T, PathNode>();//从起点到达该位置的最小代价
           
            foreach (T key in dict.Keys)
            {
                Dictionary<T, int> children = dict[key];
                foreach (var item in children.Keys)
                {
                    Node node = new Node();
                    node.parent = key;
                    node.current = item;

                    queue.Enqueue(node);
                }
            }

            while (queue.Count>0)
            {
                Node current = queue.Dequeue();

                if (!shortestCosts.ContainsKey(current.parent))
                {//添加根节点
                    PathNode node = new PathNode();
                    node.cost = 0;
                    node.paths = new List<T>();//初始化
                    node.paths.Add(current.parent);
                    shortestCosts.Add(current.parent, node);
                }

                if (shortestCosts.Keys.Contains(current.parent))
                {//如果最短路径表包含父节点
                    int currentCost = shortestCosts[current.parent].cost + dict[current.parent][current.current];

                    if (!shortestCosts.Keys.Contains(current.current))
                    {
                        PathNode node = new PathNode();
                        node.cost = currentCost;

                        List<T> temp = new List<T>();
                        for (int i = 0; i < shortestCosts[current.parent].paths.Count; i++)
                        {
                            temp.Add(shortestCosts[current.parent].paths[i]);
                        }

                        temp.Add(current.current);

                        node.paths = temp;//确定当前节点的最短路径

                        shortestCosts.Add(current.current, node);
                    }
                    else if (shortestCosts[current.current].cost > currentCost)
                    {
                        int preCosts = 0;
                        PathNode node = shortestCosts[current.current];
                        preCosts = node.cost;//把之前到改点的消耗保存起来
                        node.cost = currentCost;

                        List<T> temp = new List<T>();
                        for (int i = 0; i < shortestCosts[current.parent].paths.Count; i++)
                        {
                            temp.Add(shortestCosts[current.parent].paths[i]);
                        }

                        temp.Add(current.current);

                        node.paths = temp;//变更当前路径

                        shortestCosts[current.current] = node;//重新赋值

                        //遍历所有路径，判断路径中是否包含修改的路径，若修改，则重新计算
                        List<T> keys = new List<T>(shortestCosts.Keys);

                        for (int i = 0; i < shortestCosts.Count; i++)
                        {
                            T key = keys[i];//key

                            if (shortestCosts[key].paths.Contains(current.current))
                            {
                                PathNode pathNode = shortestCosts[key];

                                //当前到达某点的路径
                                List<T> ToAPaths = shortestCosts[current.current].paths;
                                //从某点到达shortestCosts[key]点的路径
                                List<T> FromAToEndPaths = pathNode.paths.GetRange(pathNode.paths.IndexOf(current.current), pathNode.paths.Count - pathNode.paths.IndexOf(current.current));

                                List<T> finalPaths = ToAPaths.Union(FromAToEndPaths).ToList();

                                pathNode.paths = finalPaths;
                                //当前路径的代价 = 以前总代价 - 以前到达改点的代价 + 现在到达改点的代价
                                pathNode.cost = pathNode.cost - preCosts + shortestCosts[current.current].cost;

                                shortestCosts[key] = pathNode;

                            }
                        }

                    }
                }
            }

            foreach (var key in shortestCosts.Keys)
            {
                Console.Write(key + ": " + shortestCosts[key].cost+"  path: ");
                for (int i = 0; i < shortestCosts[key].paths.Count; i++)
                {
                    Console.Write(shortestCosts[key].paths[i]);
                    if (i!= shortestCosts[key].paths.Count-1)
                    {
                        Console.Write("====>");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// BFS: 广度优先
        /// </summary>
        /// <typeparam name="T">查找的数据类型</typeparam>
        /// <param name="dict">节点关系表</param>
        /// <param name="predicate">查找的条件</param>
        public static void BreadthFirstSearch<T>(Dictionary<T,T[]> dict, Predicate<T> predicate)
        {
            bool searchResult = false;

            Queue<T> queue = new Queue<T>();
            List<T> list = new List<T>();

            foreach (T key in dict.Keys)
            {
                foreach (T item in dict[key])
                {
                    if (!list.Contains(item))
                    {
                        queue.Enqueue(item);
                    }
                }
            }

            T current = default(T);
            while (queue.Count!=0)
            {
                current = queue.Dequeue();
                if (predicate(current))
                {
                    searchResult = true;
                    break;
                }
            }

            //路径 
            Stack<T> paths = new Stack<T>();
            T it = current;
            paths.Push(it);
            bool isCanFindParent = true;

            while (isCanFindParent)
            {
                foreach (T key in dict.Keys)
                {
                    foreach (T item in dict[key])
                    {
                        if (item.Equals(it))
                        {
                            paths.Push(key);
                            it = key;
                            isCanFindParent = true;
                            break;
                        }

                        isCanFindParent = false;
                    }

                    if (isCanFindParent)
                    {
                        break;
                    }
                }
            }


            while (paths.Count!=0)
            {
                Console.Write(paths.Pop());
                if (paths.Count != 0) {
                    Console.Write("====>");
                }
            }

            Console.WriteLine();

            Console.WriteLine( "查找结果: " + searchResult);
            return;
        }
    }
}
