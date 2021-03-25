using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * test code
           int num = 123456789;
            string str = num.ToString();
            Console.WriteLine("The sum is -> {0}", Program.SumOFIntDigits(str, 0));
            Console.WriteLine("The sum is -> {0}", Program.SumOFIntDigitsThree(num));
 */
namespace seriesone.DynamicProgramming
{
    class SumOfDigitsOfANum
    {
        public static int SumOFIntDigits(string str, int index)
        {
            if (index >= str.Length)
                return 0;

            return (int)(char.GetNumericValue(str[index]) + SumOFIntDigits(str, index + 1));
        }


        public static int SumOFIntDigitsOne(int num, int index)
        {
            string str = num.ToString();

            if (index >= str.Length)
                return 0;

            return (int)(char.GetNumericValue(str[index]) + SumOFIntDigitsOne(num, index + 1));
        }

        //Best
        public static int SumOFIntDigitsThree(int num)
        {
            if (num == 0)
                return 0;

            return (num % 10 + SumOFIntDigitsThree(num / 10));
        }
    }
}
