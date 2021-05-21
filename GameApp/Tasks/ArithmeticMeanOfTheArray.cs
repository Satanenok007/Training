using System;
public static class ArithmeticMeanOfTheArray
{
    public static void Run()
    {
        int length = 7;
        int[] m1 = new int[length];
        int result;
        Function.CreateArrayWithRandomValues(m1, length);
        Function.PrintArray(m1);
        Console.WriteLine();
        result = Function.ArithmeticMean(m1);
        Console.Write("Arithmetic mean of the array: " + result);
        Console.WriteLine();
    }
}