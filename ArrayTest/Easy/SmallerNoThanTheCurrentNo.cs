using System;

namespace seriesone.ArrayTest
{
    public class SmallerNoThanTheCurrentNo
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            //declare an array of same size
            int[] status = new int[nums.Length];

            //loop from 0 to length
            for (int i = 0; i < nums.Length; i++)
            {
                var counter = 0;
                //again loop from 0 to length
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue; // if i == j ignore
                    else if (nums[i] > nums[j]) // else i > j
                        ++counter; // increment counter  
                }
                status[i] = counter;
            }

            Console.WriteLine(string.Join(",", status));
            return status;
        }

    }
}
