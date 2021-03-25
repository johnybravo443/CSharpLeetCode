using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.ArrayTest
{
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            //create array of same length as nums
            int[] result = new int[nums.Length];

            //loop from i = 1 to <= n
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                //copy (i-1) and nth into new array
                result[counter++] = nums[i];
                result[counter++] = nums[n + i];
            }
            //return array   
            return result;
        }

    }
}
