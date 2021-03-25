using System;

namespace seriesone.ArrayTest
{
    public class XOROperationInArray
    {
        public int XorOperation(int n, int start)
        {
            int[] arr = new int[n];
            var result = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = start + (2 * i);
                result = result ^ arr[i];
            }
            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine(result);
            return result;
        }
    }
}
