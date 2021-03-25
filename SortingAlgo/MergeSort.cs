namespace seriesone.SortingAlgo
{
    public class MergeSort
    {
        public void Sort(int[] nums)
        {
            if (nums.Length <= 1)
                return;

            var mid = nums.Length / 2;

            //split the array into 2
            int[] left = new int[mid];
            for (int i = 0; i < mid; i++)
                left[i] = nums[i];

            int[] right = new int[nums.Length - mid];
            for (int i = mid; i < nums.Length; i++)
                right[i - mid] = nums[i];

            //Sort the array
            Sort(left);
            Sort(right);

            //Merge the array
            Merge(left, right, nums);
        }

        private void Merge(int[] left, int[] right, int[] result)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];
        }

    }
}
