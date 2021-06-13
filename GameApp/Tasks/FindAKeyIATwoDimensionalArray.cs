using System;
public static class FindAKeyIATwoDimensionalArray
{
    public static void Run()
    {
        int[,] array = new int[,] { { 2, 3, 6, 1, 5 }, { 3, 1, 4, 1, 3 }, { 6, 7, 1, 4, 1 }, { 4, 1, 2, 3, 5 }, { 1, 6, 7, 1, 3 } };
        int[] key = new int[3] { 1, 4, 1 };


        Console.Write("Array: ");
        Console.WriteLine();
        int[,] copyArray = Function.PrintTwoDimensionalArray(array);
        Console.WriteLine();

        Console.Write("Key: ");
        Function.PrintArray(key);
        Console.WriteLine();

        Console.Write("Result: ");
        Console.WriteLine();
        char[,] result = Function.FindAKeyIATwoDimensionalArray(array, key);
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Console.Write(result[x, y]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}