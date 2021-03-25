using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem: given a string s and dictionary containing a list of words, write a function to break a string completely into valid words. Print
 *          all such possible sentenses. The same word in the dictionary can be used multiple times.
 *          
 *          Example: input = "catsanddog"
 *                  dictionary ={ "cat", "dog", "and", "cats", "mouse", "sand" }
 *                  output:
 *                      cat sand dog
 *                      cats and dog
 */
namespace seriesone.DynamicProgramming.Backtracking
{
    class WordBreak
    {
        //public static void Main(string[] args)
        //{
        //    string[] dict = { "cat", "dog", "and", "cats", "mouse", "sand" };
        //    string str = "catsanddog";

        //    Program.PrintAllSentenses(str, dict, new List<string>());
        //}


        public static void PrintAllSentenses(string str, string[] dict, List<string> partial)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(string.Join(" ", partial));
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                string st = str.Substring(0, i + 1);
                if (dict.Contains(st))
                {
                    partial.Add(st);
                    PrintAllSentenses(str.Substring(i + 1), dict, partial);
                    partial.Remove(st);
                }
            }
        }

    }
}
