using System;

namespace Cycles
{
    class Cycles
    {
        static void F11()
        {
            int i = 10;
            int result = 0;
            int y = 20;
            for (int x = 0; x < i; x++)
            {
                if (x == 8)
                {
                    break;
                }
                result = x;
            }

            Console.WriteLine(result);

            for (int x = 0; x < i; x++)
            {
                if (x % 2 != 0)
                {
                    continue;
                }
                result = x;
            }

            Console.WriteLine(result);

            do
            {
                Console.WriteLine(i);
                i--;
            } while (i > 0);

            while (y > 0)
            {
                Console.WriteLine(y);
                y--;
            }
        }
    }
}