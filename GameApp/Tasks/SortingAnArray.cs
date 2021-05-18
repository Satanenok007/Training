using System;
static public class SortingAnArray
{
    public static void Run()
    {
        int length = 7;
        int[] m1 = new int[length];
        int[] result;
        Function.CreateArrayWithRandomValues(m1, length);
        Console.Write("Оригинальный массив ");
        Function.PrintArray(m1);
        Console.WriteLine();
        result = Function.SortingTheOtherWayAround(m1);
        Console.Write("Массив наоборот ");
        Function.PrintArray(result);
        Console.WriteLine();
        result = Function.SortInAscendingOrder(m1, length);
        Console.Write("Массив по возрастанию ");
        Function.PrintArray(result);
        Console.WriteLine();
    }
}