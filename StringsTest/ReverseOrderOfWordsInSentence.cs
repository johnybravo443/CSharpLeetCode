using System;

namespace seriesone.StringsTest
{
    class ReverseOrderOfWordsInSentence
    {
        public static string ReverseOrderOfWords()
        {
            string str = "Trees are beautiful";

            if (string.IsNullOrEmpty(str))
                return "";

            string[] arr = str.Split(' ');

            //way 2 to reverse
            var mid = arr.Length / 2;
            for (int i = 1; i <= mid; i++)
            {
                var temp = arr[i - 1];
                arr[i - 1] = arr[arr.Length - i];
                arr[arr.Length - i] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));

            return string.Join(" ", arr);
        }

        public static string ReverseOrderOfWorks()
        {
            string str = "Trees are beautiful";

            if (string.IsNullOrEmpty(str))
                return "";

            string[] arr = str.Trim().Split(' ');
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));

            return string.Join(" ", arr);
        }
    }
}
