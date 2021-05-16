using System;
static class CopyArray
{
    public static void Run()
    {
        int Length = 7;
        int[] OriginalArray = new int[Length];
        int[] CopyArray = new int[Length];
        int z = 0;
        Random rnd = new Random();

        for (int x = 0; x < Length; x++)
        {
            OriginalArray[x] = rnd.Next(0, 7);
        }
        for (int x = 0; x < Length; x++)
        {
            CopyArray[x] = OriginalArray[x];
        }
        for (int x = 0; x < Length; x++)
        {
            Console.Write(OriginalArray[x]);
        }
        Console.WriteLine();
        // Console.WriteLine();
        //  for (int y = 0; y < Length; y++)
        // {
        //     Console.Write(CopyArray[y]);
        // }
        for (int x = Length - 1; x >= 0; x--)
        {
            CopyArray[z] = OriginalArray[x];
            z++;
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int y = 0; y < Length; y++)
        {
            Console.Write(CopyArray[y]);
        }
    }
}