using System.Collections.Generic;

/*
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    Input: [2, 7, 11, 15] - target = 9 Output: [0, 1] (because 2 + 7 = 9)Assume that each input has exactly one solution, 
    and you may not use the same element twice

inputs
        //int[] val = p.TwoSumUsingHashTable(new int[] { 2, 7, 11, 15 }, 9);
            //int[] val = p.TwoSumBest(new int[] { 3, 2, 4 }, 6);
            //int[] val = p.TwoSumBest(new int[] { 3, 3 }, 6);
            //Console.WriteLine(string.Join(",",val));

 */
namespace seriesone.HashTableTest
{
    class TwoSumTest
    {
        //O(1) best case
        //O(n2) worst case 
        public int[] TwoSum(int[] arr, int total)
        {
            int[] temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == total)
                    {
                        temp = new int[] { i, j };
                        return temp;
                    }
                }
            }
            return null;
        }

        //will fail for input like [3, 3] since HashTable doesn't allow duplicate keys.
        public int[] TwoSumUsingHashTable(int[] arr, int total)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                dict.Add(arr[i], i);
            }

            foreach (var node in dict)
            {
                var left = total - node.Key;
                if (dict.ContainsKey(left) && dict[left] != node.Value)
                {
                    return new int[] { node.Value, dict[left] };
                }
            }
            return null;
        }

        // O(1) - best case
        // O(n) - worst case
        public int[] TwoSumBest(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                if (dict.ContainsKey(rem))
                    return new int[] { dict[rem], i };

                dict.Add(nums[i], i);
            }

            return null;
        }
    }
}


