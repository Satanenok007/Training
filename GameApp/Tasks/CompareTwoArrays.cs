using System;
static public class CompareTwoArrays
{
    public static void Run()
    {
        int length = 7;
        int[] array1 = new int[length];
        int[] array2 = new int[length];
        int[] copyArray1;
        int[] copyArray2;
        bool result;
        copyArray1 = Function.CreateArrayWithRandomValues(array1, length);
        copyArray2 = Function.CreateArrayWithRandomValues(array2, length);
        Function.PrintArray(array1);
        Console.WriteLine();
        Function.PrintArray(array2);
        Console.WriteLine();
        result = Function.CompareTwoArrays(array1, array2);
        Console.Write(result);
    }
}