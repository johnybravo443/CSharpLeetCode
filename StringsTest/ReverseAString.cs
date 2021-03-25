using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seriesone.StringsTest
{
    class ReverseAString
    {
        // way 1
        public void StringReverse()
        {
            string str = "hellos"; //hellos

            //Way 1
            char[] ch = str.ToCharArray();

            //Way 2
            //char[] ch = new char[str.Length];
            //for (int i = 1; i <= str.Length; i++)
            //    ch[i - 1] = str[str.Length - i];

            var mid = ch.Length / 2;

            for (int i = 1; i <= mid; i++)
            {
                var temp = ch[i - 1];
                ch[i - 1] = ch[ch.Length - i];
                ch[ch.Length - i] = temp;
            }

            Console.WriteLine(ch);
        }

        // way 3, best
        public static void StringReverseTwo()
        {
            string str = "hellos"; //hellos
            StringBuilder sb = new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());

        }

        public void StringReverseThree()
        {
            string str = "apple";
            string str1 = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine(str1);

        }

        public void StringReverseUsingStack()
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
