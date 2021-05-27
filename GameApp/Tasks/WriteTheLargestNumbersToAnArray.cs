using System;
public static class WriteTheLargestNumbersToAnArray
{
    public static void Run()
    {
        int length = 7;
        int[] m1 = new int[length];
        int number = 4;
        int[] copym1;
        int[] result;

        copym1 = Function.CreateArrayWithRandomValues(m1, length);
        Function.PrintArray(copym1);
        Console.WriteLine();

        result = Function.SortingAndWritingTheLargestArrayNumbers(copym1, number);
        Console.Write("Result: ");
        Function.PrintArray(result);
        Console.WriteLine();

    }
}