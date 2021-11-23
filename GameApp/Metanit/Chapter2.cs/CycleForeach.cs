using System;

namespace Foreach
{
    class C1
    {
        static void Main()
        {
            int[] m1 = new int[] { 1, 2, 3, 4 };

            foreach (var i in "Nastya")
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (char m in "Sofia")
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            foreach (int x in m1)
            {
                if (x < m1.Length)
                {
                    Console.WriteLine(m1[x]);
                }
            }
        }
    }
}