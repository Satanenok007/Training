using System;

namespace Arrays
{
    class Arrays
    {
        static void F12()
        {
            int[] m1 = new int[4] { 1, 2, 3, 5 };

            int[] m2 = new int[] { 4, 3, 2, 1 };

            int[] m3 = new[] { 1, 2, 3, 5 };

            int[] m4 = { 1, 2, 3, 5 };

            int[,] m5 = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 } };
            int xLength = 4;
            int yLength = 4;

            foreach (int x in m1)
            {
                Console.WriteLine(x);
            }

            for (int y = 0; y < m2.Length; y++)
            {
                Console.WriteLine(y);
            }

            for (int i = 0; i < xLength; i++)
            {
                for (int j = 1; j < yLength; j++)
                {
                    Console.WriteLine(m5[i, j]);
                }
            }
        }
    }
}