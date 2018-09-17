using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace AlgrithmProj
{
    class Fabonacci
    {
        /// <summary>
        /// 测试斐波那契数列的效率
        /// </summary>
        public static void TestFabonacciEfficient(int i)
        {
            if (i<=0)
            {
                Console.WriteLine("i 必须大于 0!");
                return;
            }

            int result = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            result = calcFabonacciByRecursion(i);
            stopwatch.Stop();
            Console.WriteLine("递归计算斐波那契数列(数据规模:" + i + "): " + stopwatch.ElapsedMilliseconds + ", 最终结果: " + result);

            stopwatch.Reset();
            stopwatch.Start();
            result = calcFabonacciByDynamic(i);
            stopwatch.Stop();
            Console.WriteLine("动态规划计算斐波那契数列(数据规模:" + i + "): " + stopwatch.ElapsedMilliseconds + ", 最终结果: " + result);

        }

        /// <summary>
        /// 用递归求斐波那契数列
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int calcFabonacciByRecursion(int i)
        {
            Contract.Assert(i > 0, "calcFabonacciByRecursion(i) i 必须大于0");
            if (i<3)
            {
                return 1;
            }

            return calcFabonacciByRecursion(i - 1) + calcFabonacciByRecursion(i - 2);
        }

        /// <summary>
        /// 用动态规划求斐波那契数列
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int calcFabonacciByDynamic(int i)
        {

            Contract.Assert(i > 0, "calcFabonacciByRecursion(i) i 必须大于0");
            if (i < 3)
            {
                return 1;
            }
            else {
                int[] arr = new int[i];
                arr[1] = 1;
                arr[2] = 1;
                for (int j = 3; j < arr.Length; j++)
                {
                    arr[j] = arr[j - 1] + arr[j - 2];
                }

                return arr[i-1];
            }
        }
    }
}
