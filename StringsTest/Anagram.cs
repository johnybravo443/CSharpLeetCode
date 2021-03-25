using System;
using System.Linq;

namespace seriesone.StringsTest
{
    class Anagram
    {
        public static void CheckAnagramOne()
        {
            string st1 = "abcd";
            string st2 = "dcba";

            if (st1.Length != st2.Length)
                return;
            else if (string.IsNullOrEmpty(st1) || string.IsNullOrEmpty(st2))
                return;

            //conver to char array
            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();

            //sort both
            Array.Sort(ch1);
            Array.Sort(ch2);

            //Console.WriteLine(ch1);
            //Console.WriteLine(ch2);

            //compare both arrays
            if (ch1.SequenceEqual(ch2))
                Console.WriteLine("anagram");
            else
                Console.WriteLine("diagram");
        }

        /* Without converting to char array. using for loop.
         * Pre Req are
         * 1. the length of two is same
         * 2. if an element is presnet twoice in st2, then obviously another element of st1 will be missing from st2. hence count is not needed.
         */
        public static void CheckAnagramTwo()
        {
            string st1 = "abcd";
            string st2 = "dcba";

            if (st1.Length != st2.Length)
                return;
            else if (string.IsNullOrEmpty(st1) || string.IsNullOrEmpty(st2))
                return;

            //tracking variables
            //var count = 0;
            var flag = 0;

            //loop through first array and try to find the variable in 2nd
            for (int i = 0; i < st1.Length; i++)
            {
                flag = 0;
                //count = 0;

                //loop for 2nd array
                for (int j = 0; j < st2.Length; j++)
                {
                    //if found increment flag and count
                    if (st1[i] == st2[j])
                    {
                        flag = 1;
                        //++count;
                        //Console.WriteLine(st1[i] + " " + st2[j] + " " + flag + " " + count);
                    }
                }

                //Console.WriteLine("---" + count);

                //if flag is 0 and count > 1 then its not analgam
                if (flag == 0) // || count > 1 is not needed since if an element from st1 is not present in st2, then flag will be 0.
                {
                    //Console.WriteLine("didnt find");
                    break;
                }
            }

            //display message stating if its analgam or not.
            if (flag == 1)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Diagram");

        }

        public static bool CheckAnagramThree()
        {
            string st1 = "abcd";
            string st2 = "dxba";

            if (st1.Length != st2.Length)
                return false;
            else if (string.IsNullOrEmpty(st1) || string.IsNullOrEmpty(st2))
                return false;

            st1 = st1.ToLower();
            st2 = st2.ToLower();

            const int ENG = 26;
            int[] arr = new int[ENG];

            for(int i = 0; i < st1.Length; i++)
            {
                arr[st1[i] - 97]++;
            }

            for(int j = 0; j < st2.Length; j++)
            {
                var index = st2[j] - 97;
                
                if (arr[index] == 0)
                    return false;

                arr[index]--;
            }

            return true;
        }
    }
}
