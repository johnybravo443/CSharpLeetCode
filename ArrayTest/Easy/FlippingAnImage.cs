using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.ArrayTest.Easy
{
    class FlippingAnImage
    {
        public int[][] flipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int len = A.GetLength(1) - 1;
                for (int j = 0; j < A.GetLength(1) / 2; j++)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][len - j];
                    A[i][len - j] = temp;
                }

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i][j] == 0)
                        A[i][j] = 1;
                    else if (A[i][j] == 1)
                        A[i][j] = 0;
                    Console.Write(" " + A[i][j]);
                }
                Console.WriteLine("");
            }
            return A;
        }
    }
}

//input
//int a[,] = new int[,]
//{
//    { 1, 1, 0, 0 },
//    { 1, 0, 0, 1 },
//    { 0, 1, 1, 1 },
//    { 1, 0, 1, 0 }
//};