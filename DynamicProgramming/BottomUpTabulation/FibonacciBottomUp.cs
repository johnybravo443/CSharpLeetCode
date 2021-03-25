using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.DynamicProgramming.BottomUpTabulation
{
    class FibonacciBottomUp
    {
        //public static void Main(string[] args)
        //{
        //    int n = 10;

        //    Program.Fib(n);

        //    Console.WriteLine(string.Join(" ", Program.FibBottomUp(n)));

        //}

        //way 1
        public static void Fib(int n)
        {
            int i = 0;
            int j = 1;

            Console.WriteLine(i);
            Console.WriteLine(j);
            for (int k = 1; k <= n; k++)
            {
                var temp = i + j;
                Console.WriteLine(temp);
                i = j;
                j = temp;
            }
        }
        
        // way 2 preferred, bottom up approach
        public static int[] FibBottomUp(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int k = 2; k <= n; k++)
                dp[k] = dp[k - 1] + dp[k - 2];

            return dp;
        }
    }
}
