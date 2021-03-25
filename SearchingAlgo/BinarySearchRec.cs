namespace seriesone.SearchingAlgo
{
    class BinarySearchRec
    {
        public int BinarySearch(int[] array, int value)
        {
            return BinarySearchRecursive(array, value, 0, array.Length - 1);
        }

        public int BinarySearchRecursive(int[] array, int value, int start, int end)
        {
            if (end < start)
                return -1;

            var mid = (start + end) / 2;

            if (array[mid] == value)
                return mid;
            else if (value < array[mid])
                return BinarySearchRecursive(array, value, start, mid - 1);

            return BinarySearchRecursive(array, value, mid + 1, end);
        }
    }
}
