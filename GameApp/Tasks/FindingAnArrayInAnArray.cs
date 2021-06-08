using System;
public static class FindingAnArrayInAnArray
{
    public static void Run()
    {
        int m1length = 7;
        int m2length = 2;
        int[] m1 = new int[m1length];
        int[] m2 = new int[m2length];
        bool result;
        Function.CreateArrayWithRandomValues(m1, m1length);
        Function.PrintArray(m1);
        Console.WriteLine();
        Function.CreateArrayWithRandomValues(m2, m2length);
        Function.PrintArray(m2);
        Console.WriteLine();
        result = Function.FindingAnArrayInAnArray(m1, m2);
        Console.Write("Contents in the key array: " + result);

    }
}