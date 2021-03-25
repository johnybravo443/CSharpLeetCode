using System;

namespace seriesone.ArrayTest
{
    public class GreatestWealth
    {
        public int MaximumWealth(int[,] accounts)
        {
            var wealth = 0;
            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                var tempSum = 0;
                for (int j = 0; j < accounts.GetLength(1); j++)
                {
                    tempSum = tempSum + accounts[i,j];
                }

                if (tempSum >= wealth)
                    wealth = tempSum;
            }
            Console.WriteLine(wealth);
            return wealth;
        }
    }
}
