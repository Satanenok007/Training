using System;
public static class WriteAnArrayToAShuffle
{
    public static void Run()
    {
        int length = 7;
        int[] m1 = new int[length];
        int[] copym1;
        int[] result;

        copym1 = Function.CreateArrayWithRandomValues(m1, length);
        Function.PrintArray(copym1);
        Console.WriteLine();

        result = Function.AaddToTheMix(copym1);
        Console.Write("Result: ");
        Function.PrintArray(result);
        Console.WriteLine();

    }
}