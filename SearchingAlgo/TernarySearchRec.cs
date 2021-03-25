namespace seriesone.SearchingAlgo
{
    class TernarySearchRec
    {
        public int TernarySearch(int[] array, int value)
        {
            return TernarySearchRecursice(array, value, 0, array.Length - 1);
        }

        private int TernarySearchRecursice(int[] array, int value, int start, int end)
        {
            if (end < start)
                return -1;

            var partition = (end - start) / 3;
            var mid1 = start + partition;
            var mid2 = end - partition;

            if (value == array[mid1])
                return mid1;
            else if (value == array[mid2])
                return mid2;
            else if (value < array[mid1])
                return TernarySearchRecursice(array, value, start, mid1 - 1);
            else if (value > array[mid2])
                return TernarySearchRecursice(array, value, mid2 + 1, end);
            else
                return TernarySearchRecursice(array, value, mid1 + 1, mid2 - 1);
        }
    }
}
