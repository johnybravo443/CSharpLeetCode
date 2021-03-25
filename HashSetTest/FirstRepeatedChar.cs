using System;
using System.Collections.Generic;

namespace seriesone.HashTableTest
{
    class FirstRepeatedChar
    {
        public void RepeatedFirstChar()
        {
            string str = "a green apple";
            str = str.Replace(" ", "");
            HashSet<char> ch = new HashSet<char>();

            for(int  i = 0; i < str.Length; i++)
            {
                if (ch.Contains(str[i]))
                {
                    Console.WriteLine(str[i]);
                    break;
                }
                else
                    ch.Add(str[i]);
            }

        }
    }
}
