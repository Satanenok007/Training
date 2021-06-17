using System;
public static class PrintTheStringTheSpecifiedNumberOfTimes
{
    public static void Run()
    {
        string line1 = "ToriBlack";
        int number1 = 4;

        // string line1 = "AlletaOcean";
        // int number1 = 6;

        string line = "NinaElle";
        int number = 0;
        string result = Function.PrintTheStringTheSpecifiedNumberOfTimes(line, number);
        Console.WriteLine();
        string temp = Function.PrintTheStringTheSpecifiedNumberOfTimes(line1, number1);
    }
}