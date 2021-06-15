using System;
public static class FindAKeyIATwoDimensionalArray
{
    public static void Run()
    {
        const int arrayXLength = 6;
        const int ArrayYLength = 3;
        int[,] array = new int[ArrayYLength, arrayXLength] { { 1, 4, 1, 4, 1, 6 }, { 6, 7, 1, 4, 1, 2 }, { 2, 3, 6, 2, 1, 4 } };
        int[] key = new int[3] { 1, 4, 1 };


        Console.Write("Array: ");
        Console.WriteLine();
        int[,] copyArray = Function.PrintTwoDimensionalArray(array, ArrayYLength, arrayXLength);
        Console.WriteLine();

        Console.Write("Key: ");
        Function.PrintArray(key);
        Console.WriteLine();

        Console.Write("Result: ");
        Console.WriteLine();
        char[,] result = Function.FindAKeyIATwoDimensionalArray(array, key, arrayXLength, ArrayYLength);
        for (int y = 0; y < ArrayYLength; y++)
        {
            for (int x = 0; x < arrayXLength; x++)
            {
                Console.Write(result[y, x]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}