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
            int[] arr = { 1,2,3,4,5,6,7,8,9,10};
            int index = BinarySearch.OnBinarySearch(arr, 0, arr.Length - 1, 7);
            Console.WriteLine("index: " + index);
            //=============================================================================


        }
    }
}
