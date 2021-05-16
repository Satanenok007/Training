using System;
static class ArraySwap
{
    public static void Run()
    {
        int length = 5;
        int[] Array1 = new int[length];
        int[] Array2 = new int[length];
        int[] CopyArray1 = new int[length];
        Random rnd = new Random();
        for (int x = 0; x < length; x++)
        {
            Array1[x] = rnd.Next(1, 5);
            CopyArray1[x] = Array1[x];
        }

        for (int y = 0; y < length; y++)
        {
            Array2[y] = rnd.Next(1, 5);
        }

        for (int x = 0; x < length; x++)
        {
            Console.Write(Array1[x]);
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int y = 0; y < length; y++)
        {
            Console.Write(Array2[y]);
        }

        for (int x = 0; x < length; x++)
        {
            Array1[x] = Array2[x];
        }

        for (int y = 0; y < length; y++)
        {
            Array2[y] = CopyArray1[y];
        }

        Console.WriteLine();
        Console.WriteLine();
        for (int x = 0; x < length; x++)
        {
            Console.Write(Array1[x]);
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int y = 0; y < length; y++)
        {
            Console.Write(Array2[y]);
        }
    }
}