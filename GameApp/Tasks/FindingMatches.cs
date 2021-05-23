using System;
public static class FindingMatchesInAnArray
{
    public static void Run()
    {
        int length = 15;
        int[] m1 = new int[length];
        int[] m2 = new int[length];
        int[] result;

        Function.CreateArrayWithRandomValues(m1, length);
        Function.PrintArray(m1);
        Console.WriteLine();

        Function.CreateArrayWithRandomValues(m2, length);
        Function.PrintArray(m2);
        Console.WriteLine();

        result = Function.FindingMatchingNumbersInAnArray(m1, m2);
        Console.Write("Matching numbers in the array: ");
        Function.PrintArray(result);
        Console.WriteLine();
    }
}