using System;

namespace seriesone.ArrayTest.Easy
{
    public class MinTimeVisitingAllPoints
    {
        public int MinTimeVisitingAllPoint(int[,] points)
        {
            int counter = 1;
            int steps = 0;
            while (counter < points.GetLength(0))
            {
                int x = 0, y = 0, a = 0, b = 0;
      
                x = points[counter - 1, 0];
                y = points[counter - 1, 1];

                a = points[counter, 0];
                b = points[counter, 1];

                while (x != a || y != b)
                {
                    if (x < a && y < b)
                    {
                        ++x;
                        ++y;
                        ++steps;
                    }
                    else if (x <= a && y < b)
                    {
                        ++y;
                        ++steps;
                    }
                    else if (x < a && y <= b)
                    {
                        ++x;
                        ++steps;
                    }
                    else if (x > a && y > b)
                    {
                        --x;
                        --y;
                        ++steps;
                    }
                    else if (x >= a && y > b)
                    {
                        --y;
                        ++steps;
                    }
                    else if (x > a && y >= b)
                    {
                        --x;
                        ++steps;
                    }
                }
                counter += 1;
            }

            Console.WriteLine(steps);
            return steps;

        }
    }
}

//sample input
//input 1
//int[,] abc = new int[3, 2]
//                  {
//                    {1, 1 },
//                    {3, 4 },
//                    {-1, 0 }
//                   };

//input 2
//int[,] def = new int[2, 2]
//               {
//                { 3, 2},
//                { -2, 2}
//               };
