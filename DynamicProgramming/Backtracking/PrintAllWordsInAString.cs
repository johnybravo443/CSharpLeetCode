using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem: give a string s and dictionary containing some words. print all the possible words from the string which are present in the dictinary.
 *          Example:
 *              string = "catsanddog"
 *              dict = { "cat", "dog", "and", "cats", "mouse", "sand" }
 *              output
 *                  cat cats and sand dog
 */
namespace seriesone.DynamicProgramming.Backtracking
{
    class PrintAllWordsInAString
    {
        //public static void Main(string[] args)
        //{
        //    string[] dict = { "cat", "dog", "and", "cats", "mouse", "sand" };
        //    string str = "catsanddog";
        //    char[] wd = str.ToArray();

        //    var result = PrintAllWordsInAString.CheckWordInDict(wd, dict, new List<char>(), new List<string>(), 0);

        //}


        public static List<string> CheckWordInDict(char[] wd, string[] dict, List<char> partial, List<string> result, int start)
        {
            if (dict.Contains(string.Join("", partial.ToArray())) && !result.Contains(string.Join("", partial.ToArray())))
            {
                result.Add(string.Join("", partial.ToArray()));
                Console.WriteLine(string.Join("", partial.ToArray()));
            }

            if (start == wd.Length)
                return result;

            for (int i = start; i < wd.Length; i++)
            {
                partial.Add(wd[i]);
                result = CheckWordInDict(wd, dict, partial, result, i + 1);
                partial.Remove(wd[i]);
            }
            return result;
        }

        //public static void PrintAllSentenses(List<string> word, List<string> partial, bool[] output)
        //{
        //    if(partial.Count == word.Count)
        //    {
        //        //Console.WriteLine(string.Join(" ", partial));
        //        return;
        //    }

        //    for(int i = 0; i < word.Count; i++)
        //    {
        //        if(!output[0])
        //        {
        //            output[i] = true;
        //            partial.Add(word[i]);
        //            PrintAllSentenses(word, partial, output);
        //            output[i] = false;
        //            partial.Remove(word[i]);
        //        }
        //    }   
        //}
    }
}
