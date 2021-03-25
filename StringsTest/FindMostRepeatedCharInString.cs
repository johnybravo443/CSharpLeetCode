using System;
using System.Collections.Generic;

namespace seriesone.StringsTest
{
    class FindMostRepeatedCharInString
    {
        public void FindMostRepeatedChar()
        {
            string str = "Hellooo!!";

            if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException("string not provided");

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    var val = dict[str[i]];
                    dict[str[i]] = ++val;
                }
                else
                    dict.Add(str[i], 1);
            }

            var max = 0;
            char ch = char.MinValue;
            foreach (var d in dict)
            {
                if (d.Value >= max)
                {
                    max = d.Value;
                    ch = d.Key;
                }
            }

            Console.WriteLine($"max occuring character is -> {ch}");
        }


        public static void FindMostRepeatedCharOne()
        {
            string str = "Hellooo!!";

            if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException("string not provided");

            const int ASCII_VALUE = 256;
            int[] arr = new int[ASCII_VALUE];

            foreach(char ch in str)
            {
                arr[ch]++;
            }

            var max = 0;
            char cha = ' ';
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= max)
                {
                    max = arr[i];
                    cha = (char) i;
                }
            }

            Console.WriteLine($"character {cha} has {max} occurances");
        }
    }
}
