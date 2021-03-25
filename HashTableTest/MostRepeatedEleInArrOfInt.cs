using System;
using System.Collections.Generic;

/*
 * Find the most repeated element in an array of integers. What is the time complexity of this method? (A variation of this 
 * exercise is finding the most repeated word in a sentence. The algorithm is the same. Here we use an array of numbers for 
 * simplicity.)  
 * Input: [1, 2, 2, 3, 3, 3, 4] 
 * Output: 3 
 */

//doesn't handle the scenario where there is a tie.
namespace seriesone.HashTableTest
{
    class MostRepeatedEleInArrOfInt
    {
        public void MostRepeatedElement()
        {
            int[] arr = { 1, 2, 2, 3, 3, 3, 4 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    var val = dict[arr[i]];
                    dict[arr[i]] = ++val;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            var en = dict.GetEnumerator();
            int key = 0;
            while (en.MoveNext())
            {
                if (en.Current.Value >= key)
                    key = en.Current.Value;

                //Console.WriteLine($"{en.Current.Key} - {en.Current.Value}");
            }
            Console.WriteLine($"Most repeated number is -> {key} which occurs {dict[key]} times.");
        }
    }
}