using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* problem: print all the anagrams of a given number
 */
namespace seriesone.DynamicProgramming
{
    class PrintAllAnagramOfAString
    {
        //input
        //public static void Main(string[] args)
        //{
        //    string str = "sam";
        //    char[] ch = str.ToCharArray();
        //    PrintAllAnagram(ch, new List<char>(ch.Length), new bool[ch.Length]);
        //}

        public static void PrintAllAnagram(char[] arr, List<char> partial, bool[] output)
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
                    PrintAllAnagram(arr, partial, output);
                    output[i] = false;
                    partial.Remove(arr[i]);
                }
            }
        }
    }
}
