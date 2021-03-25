using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.StringsTest
{
    class RemoveDupCharInString
    {
        public void Main(string[] args)
        {
            string str = "Hellooo!!";
            char[] cha = str.ToCharArray();
            HashSet<char> ch = new HashSet<char>();

            var len = cha.Length;
            for (int i = 0; i < len; i++)
            {
                if (ch.Count == 0)
                    ch.Add(cha[i]);
                else if (ch.Contains(cha[i]))
                {
                    for (int j = i; j < len - 1; j++)
                    {
                        cha[j] = cha[j + 1];
                    }
                    --len;
                    //Console.WriteLine(len);
                }
                else
                    ch.Add(cha[i]);
            }
            Console.WriteLine(len);
        }
    }
}
