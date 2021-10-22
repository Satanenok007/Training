using System;

namespace RecursiveFunctions
{
    class RecursiveFunctions
    {
        static void F20()
        {
            static int TheAreaOfTheTriangle(int x, int y)
            {
                if ((x == 1) && (y == 1))
                {
                    return 1;
                }
                else if (x > 1)
                {
                    return TheAreaOfTheTriangle(x - 1, y) + y;
                }
                else
                {
                    return TheAreaOfTheTriangle(x, y - 1) + 1;
                }
            }
            int result1 = TheAreaOfTheTriangle(9, 2);
            Console.WriteLine(result1);


            static int TheSquareOfTheNumber(int x)
            {
                if (x == 1)
                {
                    return 1;
                }
                else
                {
                    return TheSquareOfTheNumber(x - 1) + 2 * x - 1;
                }
            }
            int result2 = TheSquareOfTheNumber(9);
            Console.WriteLine(result2);
        }
    }
}