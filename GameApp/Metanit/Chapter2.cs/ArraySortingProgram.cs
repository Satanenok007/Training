using System;

namespace ArraySortingProgram
{
    class ArraySortingProgram
    {
        public static void F14()
        {
            int[] m1 = new int[7] { 7, 3, 9, 18, 51, 6, 10 };
            int temp;

            for (int x = 0; x < m1.Length - 1; x++)
            {
                for (int y = x + 1; y < m1.Length; y++)
                {
                    if (m1[x] < m1[y])
                    {
                        temp = m1[x];
                        m1[x] = m1[y];
                        m1[y] = temp;
                    }
                }
            }

            for (int i = 0; i < m1.Length; i++)
            {
                Console.WriteLine(m1[i]);
            }
        }
    }
}
