using System;
public static class FindingDuplicateElements
{
    public static void Run()
    {
        int length = 7;
        int[] m1 = new int[length];
        int Number = 4;
        int[] repetitions;
        Function.CreateArrayWithRandomValues(m1, length);
        Function.PrintArray(m1);
        Console.WriteLine();
        repetitions = Function.DuplicateElements(m1, Number);
        Console.Write("Итерации на которых встречается число " + Number + ": ");
        Function.PrintArray(repetitions);
        Console.WriteLine();
    }
}