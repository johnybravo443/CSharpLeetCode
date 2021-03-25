using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * test code
 *             int[] arr = new int[] { 6, 3, 11, 9, 2, 0, 1, 10 };
            int len = arr.Length - 1;
            var val = FindMaxNumberInArrayUsingRecursion.MaxNumWithRec(arr, len);
            Console.WriteLine($"max number is -> {val}");

 */
namespace seriesone.DynamicProgramming
{
    class FindMaxNumberInArrayUsingRecursion
    {
        public static int MaxNumWithRec(int[] arr, int i)
        {
            if (i == 0)
                return arr[i];

            return Math.Max(arr[i], MaxNumWithRec(arr, i - 1));
        }
    }
}
