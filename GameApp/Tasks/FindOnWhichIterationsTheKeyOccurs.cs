using System;

static class FindOnWhichIterationsTheKeyOccurs
{
    public static void Run()
    {
        int length = 7;
        int[] originalArray = new int[length];
        int[] copyArray = new int[length];
        int[] result;
        int keyLength = 3;
        int[] key = new int[keyLength];
        int[] copyKey = new int[length];

        copyArray = Function.CreateArrayWithRandomValues(originalArray, length);
        Console.Write("Array: ");
        Function.PrintArray(copyArray);
        Console.WriteLine();

        copyKey = Function.CreateArrayWithRandomValues(key, keyLength);
        Console.Write("Key: ");
        Function.PrintArray(copyKey);
        Console.WriteLine();

        result = Function.FindOnWhichIterationsTheKeyOccurs(copyArray, copyKey);
        Console.Write("The key is on iterations: ");
        Function.PrintArray(result);
        Console.WriteLine();

        //     int[] m1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        //     int[] key2 = new int[3] { 3, 4, 5 };
        //     int[] result;

        //     Console.Write("Array: ");
        //     Function.PrintArray(m1);
        //     Console.WriteLine();

        //     Console.Write("Key: ");
        //     Function.PrintArray(key2);
        //     Console.WriteLine();

        //     result = Function.FindOnWhichIterationsTheKeyOccurs(m1, key2);
        //     Console.Write("The key is on iterations: ");
        //     Function.PrintArray(result);
        //     Console.WriteLine();
    }
}