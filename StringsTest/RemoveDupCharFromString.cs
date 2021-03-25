using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.StringsTest
{
    class RemoveDupCharFromString
    {
        //Preferred
        public static void RemoveDupHashSetOne()
        {
            string str = "Trees are beautiful";
            HashSet<char> hs = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!hs.Contains(str[i]))
                    hs.Add(str[i]);
            }

            foreach (var val in hs)
            {
                Console.Write(val);
            }
            Console.WriteLine();
        }

        //shortest
        public static void RemoveDupHashSet()
        {
            string myStr = "kkllmmnnoo";
            Console.WriteLine("Initial String: " + myStr);
            var unique = new HashSet<char>(myStr);
            Console.Write("New String after removing duplicates: ");
            foreach (char c in unique)
                Console.Write(c);
            Console.WriteLine();
        }

        //not working, the last !! is missing from result
        public static void RemoveDupIterative()
        {
            string str = "Hellooo!!";
            char[] ch = str.ToCharArray();
            var len = ch.Length;

            Console.WriteLine(string.Join(",", ch));

            for (int i = 0; i < len; i++)
            {
                var next = i + 1;
                while (next < len)
                {
                    var flag = 0;
                    if (ch[next] == ch[i])
                    {
                        //Console.WriteLine($"{ch[next]} - {ch[i]}");
                        flag = 1;
                        for (int k = next; k < len; k++)
                        {
                            if (next + 1 == ch.Length)
                                break;
                            ch[next] = ch[next + 1];
                        }
                        //ch[len - 1] = '*';
                        --len;
                        Array.Resize(ref ch, len);
                    }

                    if (flag == 0)
                        ++next;
                }
            }

            Console.WriteLine(string.Join(",", ch));
        }
    }
}
