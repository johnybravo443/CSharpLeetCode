using System;
using System.Collections.Generic;

namespace seriesone.HashTableTest
{
    class FirstNonRepeatedChar
    {
        public void ReturnFirstNonRepChar()
        {
            string str = "a green apple";
            //str = str.Replace(" ", "");
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int i = 0; i < str.Length; i++)
            {
                //if (dict.Count == 0)
                //    dict.Add(str[i], 1);
                if (dict.ContainsKey(str[i]))
                {
                    int val = dict[str[i]];
                    dict[str[i]] = ++val;
                }
                else
                    dict[str[i]] = 1;
            }

            for(int i = 0; i < str.Length; i++)
            {
                if(dict[str[i]] == 1)
                {
                    Console.WriteLine(str[i]);
                    break;
                }
            }
        }
    }
}
