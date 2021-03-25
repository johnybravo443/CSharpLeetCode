using System;

namespace seriesone.ArrayTest
{
    class CreateTargetArrayInTheGivenOrder
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] target = Array.Empty<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                Array.Resize(ref target, i + 1);

                if (target[index[i]] > 0)
                {
                    var val = index[i];
                    for (int last = target.Length - 1; last >= val; last--)
                    {
                        if (last == val)
                            target[last] = nums[i];
                        else
                            target[last] = target[last - 1];
                    }
                }
                else
                    target[index[i]] = nums[i];
            }
            Console.WriteLine(string.Join(",", target));
            return target;
        }
    }
}
