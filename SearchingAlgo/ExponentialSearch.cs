using System;

namespace seriesone.SearchingAlgo
{
    class ExponentialSearch
    {
        public static int ExpSearch(int[] array, int value)
        {
            if (array.Length == 0)
                return -1;

            int bound = 1;

            while (bound < array.Length && value > array[bound])
            {
                bound *= 2;

            }

            var left = bound / 2;
            var right = Math.Min(bound, array.Length - 1);
            BinarySearchRec b = new BinarySearchRec();
            return b.BinarySearchRecursive(array, value, left, right);
        }
    }
}
