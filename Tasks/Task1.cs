using System;

namespace Array
{
    class A
    {
        static void Main()
        {
            //array in ascending order
            int[] m1 = new int[] { 1, 4, 2, 6, 3, 5 };
            int res1;
            for (int x = 0; x < m1.Length; x++)
            {
                for (int y = 0; y < m1.Length - x - 1; y++)
                {
                    if (m1[y] > m1[y + 1])
                    {
                        res1 = m1[y];
                        m1[y] = m1[y + 1];
                        m1[y + 1] = res1;
                    }
                }
            }

            for (int x = 0; x < m1.Length; x++)
            {
                Console.WriteLine(m1[x]);
            }
            Console.WriteLine();

            //array in descending order

            int[] m2 = new int[] { 1, 4, 2, 6, 3, 5 };
            int res2;
            for (int x = 0; x < m2.Length; x++)
            {
                for (int y = 0; y < m2.Length - x - 1; y++)
                {
                    {
                        res2 = m2[y];
                        m2[y] = m2[y + 1];
                        m2[y + 1] = res2;
                    }
                }
            }

            for (int x = 0; x < m2.Length; x++)
            {
                Console.WriteLine(m2[x]);
            }
            Console.WriteLine();

            //the arithmetic mean of the array
            int[] m3 = new int[] { 1, 2, 3, 4, 5, 6 };
            int a = 0;
            int res3;

            for (int i = 0; i < m3.Length; i++)
            {
                a = a + m3[i];
            }
            res3 = a / m3.Length;
            Console.WriteLine(res3);
        }
    }
}