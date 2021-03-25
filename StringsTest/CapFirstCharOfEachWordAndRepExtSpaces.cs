using System;
using System.Text.RegularExpressions;

namespace seriesone.StringsTest
{
    class CapFirstCharOfEachWordAndRepExtSpaces
    {
        public static string CapFirstCharOfEachStringInAWord()
        {
            string str = " trees   are   beautiful ";
            str = str.Trim();

            if (string.IsNullOrEmpty(str))
                return "";

            str = Regex.Replace(str, " +", " ");

            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();
            }

            Console.WriteLine(string.Join(" ", arr));
            return string.Join(" ", arr);
        }
    }
}
