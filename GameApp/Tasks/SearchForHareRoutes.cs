using System;
public static class SearchForHareRoutes
{
    public static void Run()
    {
        int numberOfSteps = 7;
        int jump = 2;
        int result = Function.SearchForHare(numberOfSteps, jump);
        Console.Write(result);
        Console.WriteLine();
    }
}