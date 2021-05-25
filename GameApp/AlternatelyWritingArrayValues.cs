using System;
public static class AlternatelyWritingArrayValues
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
        Function.PrintArray(copym1);
        Console.WriteLine();

        copym2 = Function.CreateArrayWithRandomValues(m2, length);
        Function.PrintArray(copym2);
        Console.WriteLine();

        result = Function.AlternatelyWritingValues(copym1, copym2);
        Console.Write("Result: ");
        Function.PrintArray(result);
        Console.WriteLine();

    }
}