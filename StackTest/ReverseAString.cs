using System;
using System.Collections.Generic;

namespace seriesone.StackTest
{
    class ReverseAString
    {
        public static void StringReverseUsingStack()
        {
            string str = "abcd";
            Stack<char> ch = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                ch.Push(str[i]);
            }

            var st = ch.ToArray();
            Console.WriteLine(string.Join("", st));
        }
    }
}
