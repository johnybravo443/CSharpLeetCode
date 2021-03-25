using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Test input
 *             int[] arr = {1, 2, 3, 4, 5, 6 };
            //int[] arr = { 1, 2, 3, 5, 6 };
            Console.WriteLine("Array in sequence -> {0}", Program.ArrayInSequence(arr, 0));

 */
namespace seriesone.DynamicProgramming
{
    class ElementInSeqInArray
    {
        public static bool ArrayInSequence(int[] arr, int i)
        {
            if (i == arr.Length - 1)
                return true;

            return (arr[i + 1] == arr[i] + 1 && ArrayInSequence(arr, i + 1));
        }

    }
}
