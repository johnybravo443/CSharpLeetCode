using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.DynamicProgramming.TopDownMemorizationApproach
{
    class FibonacciTopDown
    {
        //public static void Main(string[] args)
        //{
        //    int n = 10;
        //    int[] cache = new int[11];
        //    cache[0] = 0;
        //    cache[1] = 1;
        //    var sum = Program.FibMemo(10, new int[11]);
        //    Console.WriteLine($"sum is {n} fibonacci number is -> {sum}");
        //}

        public static int FibMemo(int n, int[] cache)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (cache[n] != 0)
                return cache[n];

            var res = FibMemo(n - 1, cache) + FibMemo(n - 2, cache);
            cache[n] = res;
            return res;
        }
    }
}
