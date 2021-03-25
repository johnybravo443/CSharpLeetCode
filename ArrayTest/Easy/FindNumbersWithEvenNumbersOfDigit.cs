using System;

namespace seriesone.ArrayTest.Easy
{
    class FindNumbersWithEvenNumbersOfDigit
    {
        public int FindNumbers(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = nums[i].ToString();
                var len = temp.Length;
                if (len % 2 == 0)
                    ++counter;
            }
            Console.WriteLine(counter);
            return counter;
        }
    }
}

//input
// [12,345,2,6,7896]
