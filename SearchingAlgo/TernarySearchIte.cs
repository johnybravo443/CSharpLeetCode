namespace seriesone.SearchingAlgo
{
    class TernarySearchIte
    {
        public int TernarySearch(int[] array, int value)
        {
            return TernarySearchIterative(array, value, 0, array.Length - 1);
        }

        public int TernarySearchIterative(int[] array, int value, int start, int end)
        {
            if (start < end)
            {
                var partition = (end - start) / 3;
                var mid1 = start + partition;
                var mid2 = end - partition;

                if (value == array[mid1])
                    return mid1;
                else if (value == array[mid2])
                    return mid2;
                else if (value < array[mid1])
                    end = mid1 - 1;
                else if (value > array[mid2])
                    start = mid2 + 1;
                else
                {
                    start = mid1 + 1;
                    end = mid2 - 1;
                }
            }

            return -1;
        }
    }
}
