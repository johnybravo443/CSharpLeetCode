using System;

namespace seriesone.StringsTest
{
    class Vowel
    {
        //way 1
        public static int VowelCount(string str)
        {
            //string str = "hello";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                //Console.WriteLine(str[i]);
                if (str[i].Equals('a') || str[i].Equals('e') || str[i].Equals('i') || str[i].Equals('o') || str[i].Equals('u'))
                {
                    ++count;
                }
            }

            Console.WriteLine($"Total Vowels are -> {count}");
            return count;
        }

        //way 2
        public static int VowelCountOne()
        {
            string str = "hello";
            string vw = "aeiou";
            var count = 0;

            if (string.IsNullOrEmpty(str))
                return 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (vw.Contains(str[i].ToString().ToLower()))
                    ++count;
            }

            Console.WriteLine(count);
            return count;
        }

        //way 3. using HashSet intead of string to store vowels.
    }
}
