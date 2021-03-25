using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem: Given a list of numbers and target number, print all the unique combinations in candidates where the candidate number
 *          sum to target.
 */

//input test data
//int[] arr = new int[] { 10, 1, 2, 7, 6, 1, 5 };
//Array.Sort(arr);
//int target = 8;
//Program.AllWaysWecanChooseKInt(arr, target, 0, new List<int>(), 0);

namespace seriesone.DynamicProgramming
{
    class CandidateNumSumtoTarget
    {
        public static void AllWaysWecanChooseKInt(int[] arr, int target, int sum, List<int> partial, int index)
        {
            if (sum == target)
            {
                Console.WriteLine(string.Join(" ", partial.ToArray()));
                return;
            }

            if (index == arr.Length)
                return;

            for (int i = index; i < arr.Length; i++)
            {
                int c = arr[i];

                if (sum + c > target || i > index && arr[i] == arr[i - 1])
                    continue;

                partial.Add(c);
                AllWaysWecanChooseKInt(arr, target, sum + c, partial, i + 1);
                partial.Remove(c);
            }
        }
    }
}
