/*
 * Test input
 *            string str = "arun";
            int len = str.Length;
            Console.WriteLine("IsPalindrome -> {0}", Program.IsPalindrome(str, 0, len - 1)) ;
 
 */
namespace seriesone.DynamicProgramming
{
    class PalindromeUsingRec
    {
        public static bool IsPalindrome(string str, int i, int j)
        {
            if (i >= j)
                return true;

            return (str[i].Equals(str[j]) && IsPalindrome(str, i + 1, j - 1));
        }
    }
}
