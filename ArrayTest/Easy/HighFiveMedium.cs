using System;

namespace seriesone.ArrayTest.Easy
{
    class HighFiveMedium
    {
        public void FiveHigh()
        {
            int[,] items = new int[,]
            {
                {1, 91 },
                {1, 92 },
                {2, 93 },
                {2, 97 },
                {1, 60 },
                {2, 77 },
                {1, 65 },
                {1, 87 },
                {1, 100 },
                {2, 100 },
                {2, 76 }
            };

            int[] st = Array.Empty<int>();
            int len = 0;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (st.Length == 0)
                    {
                        Array.Resize(ref st, st.Length + 1);
                        st[len++] = items[i, j];
                    }
                    else
                    {
                        if (!Array.Exists(st, e => e == items[i, j]))
                        {
                            Array.Resize(ref st, st.Length + 1);
                            st[len++] = items[i, j];
                        }

                    }
                }
            }

            int[,] answer = new int[st.Length, 2];

            for (int i = 0; i < st.Length; i++)
            {
                int current = st[i];
                int[] val = Array.Empty<int>();
                var index = 0;
                for (int j = 0; j < items.GetLength(0); j++)
                {
                    if (items[j, 0] == current)
                    {
                        Array.Resize(ref val, j + 1);
                        val[index++] = items[j, 1];
                    }
                }

                Array.Sort(val);
                Array.Reverse(val);

                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += val[j];
                }

                Console.WriteLine("average for {0} is -> {1}", current, sum / 5);
                answer[i, 0] = current;
                answer[i, 1] = sum / 5;
            }

            Console.WriteLine();

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Console.Write(answer[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
