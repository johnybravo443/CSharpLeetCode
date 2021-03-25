using System;
namespace seriesone.ArrayTest.Easy
{
    class FindTheHighestAltitide
    {
        public class Solution
        {
            public int LargestAltitude(int[] gain)
            {
                int[] temp = new int[gain.Length + 1];
                temp[0] = 0;
                int max = temp[0];
                for (int i = 1; i <= gain.Length; i++)
                {
                    temp[i] = temp[i - 1] + gain[i - 1];

                    if (temp[i] > max)
                    {
                        max = temp[i];
                    }
                }

                Console.WriteLine(string.Join(",", temp));
                Console.WriteLine(max);
                return max;
            }
        }
    }
}
