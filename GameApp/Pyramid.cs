using System;
static class Pyramid
{
    public static void Run()
    {
        int length = 7;
        for (int y = 0; y < length; y++)
        {
            for (int x = 0; x < length; x++)
            {
                if (x >= y && x <= length - y - 1)
                {
                    Console.Write("w");
                }
                else if (y > length / 2)
                {
                    if (x <= y && x >= length - y - 1)
                    {
                        Console.Write("w");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}