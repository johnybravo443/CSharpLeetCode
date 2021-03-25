using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem : given an array. print all the peermutations of the given array
 */

//test input
//public static void Main(string[] args)
//{
//    int[] arr = { 1, 2, 3 };
//    Program.PrintAllPermutationOfArray(arr, new List<int>(arr.Length), new bool[arr.Length]);
//}

namespace seriesone.DynamicProgramming
{
    class PrintAllPermutationOfGivenArray
    {
        public static void PrintAllPermutationOfArray(int[] arr, List<int> partial, bool[] output)
        {
            if (partial.Count == arr.Length)
            {
                Console.WriteLine(string.Join(" ", partial.ToArray()));
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!output[i])
                {
                    output[i] = true;
                    partial.Add(arr[i]);
                    PrintAllPermutationOfArray(arr, partial, output);
                    output[i] = false;
                    partial.Remove(arr[i]);
                }
            }
        }

    }
}
