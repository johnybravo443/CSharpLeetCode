using System;

namespace seriesone.ArrayTest
{
    public class RunningSumOf1DArray
    {
        public int[] RunningSum(int[] nums)
        {
            var temp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var count = 0;
                var counter = i;
                while (counter >= 0)
                {
                    count += nums[counter--];
                }
                temp[i] = count;
            }
            return temp;
        }
    }
}
