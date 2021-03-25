using System;

namespace seriesone.ArrayTest
{
    public class DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            // find length of array
            var len = 0;
            for (int i = 0; i < nums.Length; i += 2)
                len += nums[i];
            Console.WriteLine("target array len is -> {0}", len);

            int[] target = new int[len];
            var counter = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 1; j <= nums[i]; j++)
                {
                    target[counter++] = nums[i + 1];
                }
            }

            Console.WriteLine(string.Join(",", target));
            return target;
        }

    }
}


//[1,2,3,4]
//[1,1,2,3]
