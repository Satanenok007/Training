using System;

static class WriteValuesGreaterThanTheSpecifiedValue
{
    public static void Run()
    {
        int length = 7;
        int number = 5;
        int [] originalArray = new int [length];
        int [] copyArray = new int [length];
        int [] result;

        copyArray = Function.CreateArrayWithRandomValues(originalArray, length);
        Function.PrintArray(copyArray);
        Console.WriteLine();

        result = Function.WriteValuesGreaterThanTheSpecifiedValue(originalArray, number);
        Console.Write("Values that are greater than: " + number);
        Console.WriteLine();
        
        Function.PrintArray(result);
        Console.WriteLine();
    }
}