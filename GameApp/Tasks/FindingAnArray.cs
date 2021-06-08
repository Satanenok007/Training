using System;
static public class FindingAnArray
{
    public static void Run()
    {
        int length = 7;
        int length2 = 3;
        int number = 3;
        int[] array1 = new int[length];
        int[] array2 = new int[length2];
        int[] copyArray1;
        int[] copyArray2;
        bool result;
        copyArray1 = Function.CreateArrayWithRandomValues(array1, length);
        copyArray2 = Function.CreateArrayWithRandomValues(array2, length2);
        Function.PrintArray(array1);
        Console.WriteLine();
        Function.PrintArray(array2);
        Console.WriteLine();
        result = Function.FindingAnArray(array1, array2, number);
        Console.Write(result);
    }
}