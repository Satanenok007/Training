using System;

static class FindOnWhichIterationsTheKeyOccurs
{
    public static void Run()
    {
        int length = 7;
        int [] originalArray = new int [length];
        int [] copyArray = new int [length];
        int[] result;
        int keyLength = 3;
        int [] key = new int [keyLength];
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
    }
}