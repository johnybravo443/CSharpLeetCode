using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesone.ArrayTest
{
    public class KidsWithGreatestNoOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> answer = new List<bool>(candies.Length);
            // find max value
            var maxValue = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] >= maxValue)
                    maxValue = candies[i];
            }
            // run for loop
            //check how much deficit he/she is from the max
            //if that deficit is less than or equal to extraCandies, add true
            // else add false.
            var counter = 0;
            foreach (var candie in candies)
            {
                var deficit = maxValue - candie;
                if (deficit > extraCandies)
                    answer.Insert(counter++, false);
                else
                    answer.Insert(counter++, true);
            }
            return answer;
        }
    }
}
