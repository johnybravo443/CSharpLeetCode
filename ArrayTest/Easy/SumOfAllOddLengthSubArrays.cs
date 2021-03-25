using System;

namespace seriesone.ArrayTest.Easy
{
    class SumOfAllOddLengthSubArrays
    {
        public class Solution
        {
            public int SumOddLengthSubarrays(int[] arr)
            {
                int sum = 0;
                int len = 1;
                while (len <= arr.Length)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        var maxLimit = i + len;

                        if (maxLimit > arr.Length)
                            break;

                        for (int j = i; j < maxLimit; j++)
                            sum = sum + arr[j];
                    }
                    len += 2;
                }
                Console.WriteLine(sum);
                return sum;
            }
        }
    }
}
