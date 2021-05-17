using System;

static class Function
{

    public static int[] CombiningArraysIntoOne(int[] array1, int[] array2)
    {
        int[] CombiningArray = new int[array1.Length + array2.Length];
        int x = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            CombiningArray[i] = array1[i];
        }
        for (int y = array1.Length; y < CombiningArray.Length; y++)
        {
            CombiningArray[y] = array2[x];
            x++;

        }
        return CombiningArray;
    }
    public static int[] ReturningArray(int number)
    {
        int[] Array = new int[number];
        Random random = new Random();
        for (int i = 0; i < number; i++)
        {
            Array[i] = i;
        }
        return Array;
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }

    public static int[] CreateArrayWithRandomValues(int[] array, int length)
    {
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(0, 10);
        }
        return array;
    }

}
