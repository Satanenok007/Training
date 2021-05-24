using System;
public static class FindingMismatchesInAnArray
{
    public static void Run()
    {
        int length = 7;
        int[] m1 = new int[length];
        int[] copym1;
        int[] m2 = new int[length];
        int[] copym2;
        int[] result;

        copym1 = Function.CreateArrayWithRandomValues(m1, length);
        Function.PrintArray(m1);
        Console.WriteLine();

        copym2 = Function.CreateArrayWithRandomValues(m2, length);
        Function.PrintArray(m2);
        Console.WriteLine();

        result = Function.FindingMismatchedValues(copym1, copym2);
        Console.Write("Non-matching values: ");
        Function.PrintArray(result);
        Console.WriteLine();

    }
}