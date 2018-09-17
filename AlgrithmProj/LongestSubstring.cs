using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgrithmProj
{
    class LongestSubstring
    {
        public static void TestLongestSubstring(string str1,string str2)
        {
            string result = ""; 

            result = calcLongestSubstringByDynamic(str1, str2);
            Console.WriteLine("动态规划计算结果: " +result);
        }

        /// <summary>
        /// 用动态规划来计算最长子串
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public static string calcLongestSubstringByDynamic(string str1,string str2)
        {
            //两个字符串比较结果的映射表
            int[,] compareMapResultTable = new int[str1.Length + 1, str2.Length + 1];

            for (int i = str1.Length-2; i >= 0; i--)
            {
                for (int j = str2.Length -2; j >= 0 ; j--)
                {
                    if (str1[i] == str2[j])
                    {//算法经典之处
                        compareMapResultTable[i, j] = 1 + compareMapResultTable[i + 1, j + 1];
                    }
                    else {
                        compareMapResultTable[i, j] = 0;
                    }
                }
            }

            //找出最长的子串
            int maxLength = -1;
            int index = -1;
            for (int i = 0; i < compareMapResultTable.GetUpperBound(0); i++)
            {
                for (int j = 0; j < compareMapResultTable.GetUpperBound(1); j++)
                {
                    if (compareMapResultTable[i,j] > maxLength)
                    {
                        maxLength = compareMapResultTable[i, j];
                        index = i;
                    }
                }
            }

            return str1.Substring(index, maxLength);
        }
    }
}
