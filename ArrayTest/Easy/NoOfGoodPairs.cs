using System;

namespace seriesone.ArrayTest
{
    public class NoOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int pairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        ++pairs;
                }
            }
            Console.WriteLine(pairs);
            return pairs;
        }

    }
}
