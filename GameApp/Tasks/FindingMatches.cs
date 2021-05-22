using System;
public static class FindingMatchesInAnArray
{
    public static void Run()
    {
        int length = 7;
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
        Console.Write("Matching numbers in the array: " + result);
        Console.WriteLine();
        // int x = 0;
        // for (int x = 0; x < array1.Length; x++)
        // {
        //     if (array1[x] == array2[y])
        //     {
        //         numberOfRepetitions[i] = x;
        //         i++;
        //     }
        //     y++;
        // }
    }
}