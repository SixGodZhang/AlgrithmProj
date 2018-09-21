using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgrithmProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //======================测试斐波那契数列=======================================
            //int[] arr = new int[] { 10, 20,35,45};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Fabonacci.TestFabonacciEfficient(arr[i]);
            //}
            //=============================================================================

            //========================测试两个字符串的最大子串=============================
            //LongestSubstring.TestLongestSubstring("raveADKaaaaaaaaaSPKOnWER", "havdaaaauiAUSDocWER");
            //=============================================================================

            //=========================测试二分法==========================================
            //int[] arr = { 1,2,3,4,5,6,7,8,9,10};
            //int index = BinarySearch.OnBinarySearch(arr, 0, arr.Length - 1, 7);
            //Console.WriteLine("index: " + index);
            //=============================================================================

            //=========================测试冒泡法==========================================
            //int[] arr = { 2, 3, 5, 1, 6, 9, 0, 7, 4, 3 };
            //SortMethods.BubbleSort(arr);
            //=============================================================================

            //=========================测试选择排序法==========================================
            //int[] arr = { 2, 3, 5, 1, 6, 9, 0, 7, 4, 3 };
            //SortMethods.SelectSort(arr);
            //=============================================================================

            //=========================测试快速排序==========================================
            //int[] arr = { 2, 3, 5, 1, 6, 9, 0, 7, 4, 3 };
            //SortMethods.QuickSort(arr,0,arr.Length-1);
            //arr.tostring();
            //=============================================================================

            //=========================测试广度优先==========================================
            //Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
            //dict.Add("a", new string[] { "b","c","d"});
            //dict.Add("b", new string[] { "c","f" });
            //dict.Add("c", new string[] { "f","g" });
            //dict.Add("d", new string[] { "c","g" });
            //dict.Add("e", new string[] { "f" });
            //dict.Add("f", new string[] { "g" });
            //dict.Add("g", new string[] {  });
            //GraphSearch.BreadthFirstSearch<string>(dict, (t) => { return t == "h"; });
            //=============================================================================

            //=========================测试狄克斯特拉算法==========================================
            Dictionary<string, Dictionary<string, int>> testdata = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> PA = new Dictionary<string, int>();
            PA.Add("b", 2);
            PA.Add("c", 7);
            testdata.Add("a", PA);

            Dictionary<string, int> PB = new Dictionary<string, int>();
            PB.Add("e", 5);
            PB.Add("d", 3);
            testdata.Add("b", PB);

            Dictionary<string, int> PC = new Dictionary<string, int>();
            PC.Add("f", 4);
            testdata.Add("c", PC);

            Dictionary<string, int> PD = new Dictionary<string, int>();
            PD.Add("c", 1);
            PD.Add("f", 6);
            testdata.Add("d", PD);

            Dictionary<string, int> PE = new Dictionary<string, int>();
            PE.Add("f", 8);
            testdata.Add("e", PE);

            GraphSearch<string>.DijkstraSearch(testdata);
            //=====================================================================================




        }
    }
}
