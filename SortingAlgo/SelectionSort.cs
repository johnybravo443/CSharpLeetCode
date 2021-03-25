using System;

namespace seriesone.SortingAlgo
{
    class SelectionSort
    {
        public void SelectionSortAlgo()
        {
            int[] nums = new int[] { 5, 3, 3, 4, 2, 1, 10 };

            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                        minIndex = j;
                }

                var temp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = temp;
            }
            Console.WriteLine(string.Join(",", nums));
        }
    }
}
