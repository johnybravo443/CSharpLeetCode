using System;

namespace seriesone.ArrayTest.Easy
{
    class CountGoodTriplets
    {
        public int CountGoodTriplet(int[] arr, int a, int b, int c)
        {
            int count = 0;

            for (int i = 1; i <= arr.Length - 2; i++)
            {
                int x = arr[i - 1];
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    int y = arr[j - 1];
                    for (int k = j + 1; k <= arr.Length; k++)
                    {
                        int z = arr[k - 1];

                        if ((Math.Abs(x - y) <= a) && (Math.Abs(y - z) <= b) && (Math.Abs(x - z) <= c))
                        {
                            count += 1;
                            Console.WriteLine("{0},{1},{2}", x, y, z);
                        }
                    }
                }
            }

            Console.WriteLine(count);
            return count;
        }

    }
}

//input (new int[] {3,0,1,1,9,7}, 7, 2, 3);