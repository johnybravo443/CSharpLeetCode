using System;
using System.Linq;

namespace seriesone.StringsTest
{
    class Palindrome
    {
        public void CheckPalindrome()
        {
            string str = "malayaalam"; //madam
            var mid = str.Length / 2;
            var flag = false;

            for (int i = 1; i <= mid; i++)
            {
                if (str[i - 1] == str[str.Length - i])
                    flag = true;
                else
                    flag = false;
            }
            Console.WriteLine(flag);
        }

        public void CheckPalindromeTwo()
        {
            string str = "malayalam";
            string str1 = new string(str.ToCharArray().Reverse().ToArray());
            bool b = string.Equals(str, str1);
            Console.WriteLine(b);

        }
    }
}
