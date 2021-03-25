using System;

namespace seriesone.SortingAlgo
{
    class BubbleSort
    {
        public void BubbleSortAlgo(string[] args)
        {
            int[] nums = new int[] { 5, 4, 3, 2, 1, 4 };
            var isSorted = false;
            for (int i = 1; i <= nums.Length; i++)
            {
                isSorted = true;
                for (int j = 0; j < nums.Length - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted)
                    break;
            }
            Console.WriteLine(string.Join(",", nums));
        }
    }
}
