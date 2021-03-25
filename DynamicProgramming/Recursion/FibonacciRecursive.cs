using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.DynamicProgramming.Recursion
{
    class FibonacciRecursive
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"the 10 fib numbers are -> {FibonacciRecursive.Fib(10)}");
        }

        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            var res = Fib(n - 1) + Fib(n - 2);
            return res;
        }
    }
}
