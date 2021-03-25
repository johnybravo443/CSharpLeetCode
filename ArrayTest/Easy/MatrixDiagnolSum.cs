using System;

namespace seriesone.ArrayTest.Easy
{
    class MatrixDiagnolSum
    {
        public int diagonalSum(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                var counter = (mat.GetLength(0) - 1) - i;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j || j == counter)
                        sum += mat[i,j];
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}

//input
//int[,] diag = new int[,]
//{
//                {1,2,3},
//                {4,5,6},
//                {7,8,9}
//};