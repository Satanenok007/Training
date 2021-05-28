using System;

static class Key
{
    public static void Run()
    {
        int length = 7;
        int [] originalArray = new int [length];
        int [] copyArray = new int [length];
        bool result;
        int keyLength = 2;
        int [] key = new int [keyLength];
        int[] copyKey;

        copyArray = Function.CreateArrayWithRandomValues(originalArray, length);
        Function.PrintArray(copyArray);
        Console.WriteLine();

        copyKey = Function.CreateArrayWithRandomValues(key, keyLength);
        Console.Write("Key: ");
        Function.PrintArray(key);
        Console.WriteLine();

        result = Function.FindingTheKey(originalArray, copyKey);
        Console.Write("Key content in the array: ");
        Console.Write(result);
        Console.WriteLine();
    }
}




// Console.WriteLine();
// Console.WriteLine();

// for (int x = 0; x < m1Length; x++)
// {
//     Console.Write(m1[x]);
// }