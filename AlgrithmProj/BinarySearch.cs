namespace AlgrithmProj
{
    class BinarySearch
    {
        public static int OnBinarySearch(int[] arr,int start,int end ,int value)
        {
            int middle = (start + end) / 2;
            if (arr[middle] == value)
            {
                return middle;
            }

            if (arr[middle] > value)
            {
                end = middle;
            }
            else {
                start = middle;
            }

            return OnBinarySearch(arr, start, end, value);
        }
    }
}
