using System;
static class WriteAllArrayValuesThatAreLessThanTheSpecifiedValue
{
    public static void Run()
    {
        int length = 15;
        int number = 7;
        int[] originalArray = new int[length];
        int[] copyArray = new int[length];
        int[] result;

        copyArray = Function.CreateArrayWithRandomValues(originalArray, length);
        Function.PrintArray(copyArray);
        Console.WriteLine();

        result = Function.WriteValuesLessThanTheSpecifiedValue(originalArray, number);
        Console.Write("Values that are less than: " + number);
        Console.WriteLine();

        Function.PrintArray(result);
        Console.WriteLine();
    }
}