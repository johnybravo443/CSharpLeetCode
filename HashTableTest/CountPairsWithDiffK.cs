using System;
using System.Collections.Generic;

/*
 * Given an array of integers, count the number of unique pairs of integers that have difference k. 
 * Input: [1, 7, 5, 9, 2, 12, 3] K=2 
 * Output: 4 
 * We have four pairs with difference 2: (1, 3), (3, 5), (5, 7), (7, 9). Note that we only want the number of these pairs, 
 * not the pairs themselves.
 */
namespace seriesone.HashTableTest
{
    class CountPairsWithDiffK
    {
        public int UniquePairOfIntWithdiffK(int[] arr, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                    if (i == j)
                        continue;
                    else
                    {
                        if (Math.Abs(arr[i] - arr[j]) == k)
                        {
                            //Console.WriteLine($"{arr[i]} - {arr[j]}");
                            if (dict.ContainsKey(arr[i]))
                            {
                                if (dict.ContainsKey(arr[j]))
                                    continue;
                                else
                                {
                                    // Console.WriteLine($" -------> {arr[j]} - {arr[i]}");
                                    dict.Add(arr[j], arr[i]);
                                }

                            }
                            else if (dict.ContainsKey(arr[j]))
                            {
                                if (dict[arr[j]] == arr[i])
                                    continue;
                            }
                            else
                            {
                                // Console.WriteLine($" -------> {arr[i]} - {arr[j]}");
                                dict.Add(arr[i], arr[j]);
                            }
                        }
                    }
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            return dict.Count;
        }
    }
}