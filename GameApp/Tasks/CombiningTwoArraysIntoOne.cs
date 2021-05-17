using System;
static public class CombiningTwoArraysIntoOne
{
    public static void Run()
    {
        int length = 7;
        int[] Array1 = new int[length];
        int[] Array2 = new int[length];
        int[] Result;
        Function.CreateArrayWithRandomValues(Array1, length);
        Function.CreateArrayWithRandomValues(Array2, length);
        Function.PrintArray(Array1);
        Console.WriteLine();
        Function.PrintArray(Array2);
        Console.WriteLine();
        Result = Function.CombiningArraysIntoOne(Array1, Array2);
        Function.PrintArray(Result);
    }
}