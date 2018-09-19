using System.Collections;
using System.Collections.Generic;

namespace AlgrithmProj
{
    public static class Extention {
        public static void tostring(this System.Array array)
        {
            IEnumerator enumrator = array.GetEnumerator();
            while (enumrator.MoveNext()) {
                System.Console.Write(enumrator.Current + ",");
            }
        }
    }

    class SortMethods
    {
        public static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            arr.tostring();
        }

        public static void SelectSort(int[] arr)
        {
            int maxIndex = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j] < arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != arr.Length - i -1)
                {
                    temp = arr[maxIndex];
                    arr[maxIndex] = arr[arr.Length - i -1];
                    arr[arr.Length - i -1] = temp;
                }

                maxIndex = 0;
            }

            //输出
            arr.tostring();
        }

        public static void QuickSort(int[] arr,int begin, int end)
        {
            if (end - begin < 2)
                return;
            int middle = EnsureMiddlePosition(arr,begin,end);
            QuickSort(arr, begin, middle-1);
            QuickSort(arr, middle+1, end);
        }

        public static int EnsureMiddlePosition(int[] arr,int begin,int end)
        {
            int pivot = arr[begin];
            int low = begin;
            int high = end;

            while (low < high)
            {
                
                while (high > low && arr[high] > pivot)
                {
                    high--;
                }

                arr[low] = arr[high];

                while (low < high && arr[low] <= pivot)
                {
                    low++;
                }

                arr[high] = arr[low];
                
            }

            arr[low] = pivot;

            return low;

        }
    }
}
