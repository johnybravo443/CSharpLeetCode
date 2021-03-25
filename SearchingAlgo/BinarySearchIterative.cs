namespace seriesone.SearchingAlgo
{
    class BinarySearchIterative
    {
        public int BinarySearchIte(int[] array, int value)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == value)
                    return middle;
                else if (value < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}
