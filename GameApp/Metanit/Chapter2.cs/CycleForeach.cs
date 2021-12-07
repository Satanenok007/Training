using System;

namespace Foreach
{
    class C1
    {
        static void F1()
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
                Console.WriteLine(m1[x]);
            }
        }
    }
}