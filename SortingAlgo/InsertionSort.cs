using System;

namespace seriesone.SortingAlgo
{
    public class InsertionSort
    {
        public int[] InsertionSortAlgo(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                var current = nums[i];
                var j = i - 1;
                while(j >= 0 && nums[j] >= current)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = current; 
            }
            Console.WriteLine($"{string.Join(",", nums)}");
            return nums;
        }
    }
}
