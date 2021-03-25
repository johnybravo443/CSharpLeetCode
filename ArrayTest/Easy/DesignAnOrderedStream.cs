using System;
using System.Collections.Generic;

namespace seriesone.ArrayTest.Easy
{
    public class DesignAnOrderedStream
    {
        public string[] stream;
        int ptr = 1;
        public DesignAnOrderedStream(int n)
        {
            stream = new string[n];
        }

        public IList<string> Insert(int idKey, string value)
        {
            IList<string> st = new List<string>();
            stream[idKey - 1] = value;
            var count = 0;
            if (ptr == idKey)
            {
                for (int i = ptr; i <= stream.Length; i++)
                {
                    if (string.IsNullOrEmpty(stream[i - 1]))
                        break;
                    else
                    {
                        st.Insert(count++, stream[i - 1]);
                        ptr += 1;
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(",", st));
            return st;
        }
    }
}

//Testing Code
//DesignAnOrderedStream os = new DesignAnOrderedStream(5);
//os.Insert(3, "ccccc");
//os.Insert(1, "aaaaa");
//os.Insert(2, "bbbbb");
//os.Insert(5, "eeeee");
//os.Insert(4, "ddddd");
//Console.WriteLine("[{0}]", string.Join(",", os.stream));
