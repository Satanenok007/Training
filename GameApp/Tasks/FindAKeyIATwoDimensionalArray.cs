using System;
public static class FindAKeyIATwoDimensionalArray
{
    public static void Run()
    {
        const int arrayXLength = 4;
        const int ArrayYLength = 4;
        const int keyLength1 = 2;
        const int keyLength2 = 2;
        int[,] array = new int[ArrayYLength, arrayXLength] { { 1, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 1 } };
        int[,] key = new int[keyLength1, keyLength2] { { 1, 1 }, { 1, 1 } };


        Console.Write("Array: ");
        Console.WriteLine();
        int[,] copyArray = Function.PrintTwoDimensionalArray(array, ArrayYLength, arrayXLength);
        Console.WriteLine();

        Console.Write("Key: ");
        Console.WriteLine();
        int[,] copyKey = Function.PrintTwoDimensionalArray(key, keyLength1, keyLength2);
        Console.WriteLine();

        Console.Write("Result: ");
        Console.WriteLine();
        char[,] result = Function.FindAKeyIATwoDimensionalArray(array, key, arrayXLength, ArrayYLength, keyLength1, keyLength2);
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