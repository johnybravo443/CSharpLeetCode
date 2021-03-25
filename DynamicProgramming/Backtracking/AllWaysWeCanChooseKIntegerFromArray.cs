using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Problem : Given integer array, print all the subarrays of length K from it. condition i < j
 */

//test input
//int[] arr = { 3, 2, 5, 8 };
//int k = 3;
//Program.AllWaysWecanChooseKInt(arr, 3, new List<int>(arr.Length), 0);

namespace seriesone.DynamicProgramming
{
    class AllWaysWeCanChooseKIntegerFromArray
    {
        public static void AllWaysWecanChooseKInt(int[] arr, int k, List<int> partial, int index)
        {
            if (partial.Count == k)
            {
                Console.WriteLine(string.Join(" ", partial.ToArray()));
                return;
            }

            if (index == arr.Length)
                return;

            for (int i = index; i < arr.Length; i++)
            {
                partial.Add(arr[i]);
                AllWaysWecanChooseKInt(arr, k, partial, i + 1);
                partial.Remove(arr[i]);
            }
        }


        //this backtracking picks each options and tries with once including and other time exclusing it.
        public static void AllWaysWecanChooseKIntWay2(int[] arr, int k, List<int> partial, int index)
        {
            if (partial.Count == k)
            {
                Console.WriteLine(string.Join(" ", partial.ToArray()));
                return;
            }

            if (index == arr.Length)
                return;

            for (int i = index; i < arr.Length; i++)
            {
                partial.Add(arr[i]);
                AllWaysWecanChooseKIntWay2(arr, k, partial, i + 1);
                partial.Remove(arr[i]);
                AllWaysWecanChooseKIntWay2(arr, k, partial, i + 2);
            }
        }
    }
}
