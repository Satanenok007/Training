using System;
static class ReturningAnArray
{
    public static void Run() {
        int x = 5;
        int[] Result;
        Result = Function.ReturningArray(x);
        Function.PrintArray(Result);
    }
}