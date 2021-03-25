namespace seriesone.SortingAlgo
{
    class QuickSort
    {
        public void QuickSortAlgo(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            //partition
            var boundary = Partition(array, start, end);

            //sort left
            Sort(array, start, boundary - 1);

            //sort right
            Sort(array, boundary + 1, end);
        }

        private int Partition(int[] array, int start, int end)
        {
            var pivot = array[end];
            var boundary = start - 1;

            for(int i = start; i <= end; i++)
            {
                if(array[i] <= pivot)
                {
                    ++boundary;
                    var temp = array[i];
                    array[i] = array[boundary];
                    array[boundary] = temp;
                }
            }

            return boundary;
        }
    }
}
