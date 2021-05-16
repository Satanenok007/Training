using System;
static class CountingTheSameValues
{
    public static void Run()
    {
        int length = 7;
        int[] Array = new int[length];
        int z = 0;
        CreateArrayWithRandomValues(Array, length);
        PrintArray(Array, length);


        // for (int x = 0; x < length; x++)
        // {
        //     for (int y = x + 1; y < length; y++)
        //     {
        //         if (Array[y] == Array[x])
        //         {
        //             z++;
        //         }
        //     }
        // }
        for (int x = 0; x < length; x++)
        {
            for (int y = x + 1; y < length; y++)
            {
                if (Array[y] == Array[x])
                {
                    bool isContaiend = IsArrayContainsNumber(Array, Array[x]);
                    if (isContaiend == true)
                    {
                        z++;
                    }
                }
            }
        }

        Console.WriteLine();
        Console.Write(z);
        Console.WriteLine();

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
        static int[] CreateArrayWithRandomValues(int[] array, int length)
        {
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 10);
            }
            return array;
        }
        static void PrintArray(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
        }

    }
}