using System;
public static class FindAKeyIATwoDimensionalArray
{
    public static void Run()
    {
        const int xLength = 5;
        const int yLength = 3;
        int[,] array = new int[yLength, xLength] { { 3, 1, 4, 1, 3 }, { 6, 7, 1, 4, 1 }, { 2, 3, 6, 1, 5 } };
        int[] key = new int[3] { 1, 4, 1 };


        Console.Write("Array: ");
        Console.WriteLine();
        int[,] copyArray = Function.PrintTwoDimensionalArray(array, yLength, xLength);
        Console.WriteLine();

        Console.Write("Key: ");
        Function.PrintArray(key);
        Console.WriteLine();

        Console.Write("Result: ");
        Console.WriteLine();
        char[,] result = Function.FindAKeyIATwoDimensionalArray(array, key, xLength, yLength);
        for (int y = 0; y < yLength; y++)
        {
            for (int x = 0; x < xLength; x++)
            {
                Console.Write(result[y, x]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}