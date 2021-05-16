using System;
using System.Linq;
static class FindingTheSameValues
{
    public static void Run()
    {
        int length = 5;
        int z = 0;
        int[] Array1 = new int[length];
        int[] Array2 = new int[length];
        int[] Result = new int[length];

        CreateArrayWithRandomValues(Array1, length);

        PrintArray(Array1, length);

        DoubleWriteLine();

        CreateArrayWithRandomValues(Array2, length);

        PrintArray(Array2, length);
        DoubleWriteLine();

        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < length; y++)
            {
                if (Array1[y] == Array1[x])
                {
                    bool isContaiend = IsArrayContainsNumber(Result, Array1[x]);
                    if (isContaiend == false)
                    {
                        Result[z] = Array1[x];
                        z++;
                    }
                }
            }
        }
        PrintArray(Result, length);


        static bool IsArrayContainsNumber(int[] m1, int value)
        {
            bool isContained = false;

            for (int i = 0; i < m1.Length; i++)
            {
                if (m1[i] == value)
                {
                    isContained = true;
                    break;
                }
            }

            return isContained;
        }

        static void PrintArray(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
        }
        static int[] CreateArrayWithRandomValues(int[] array, int length)
        {
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 10);
            }
            return array;
        }
        static void DoubleWriteLine()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}