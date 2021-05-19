using System;

static class Function
{

    public static int[] DuplicateElements(int[] array, int number)
    {
        int[] NumberOfRepetitions = new int[array.Length];
        int y = 0;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] == number)
            {
                NumberOfRepetitions[y] = x;
                y++;
            }
        }
        return NumberOfRepetitions;
    }

    public static int[] SortingTheOtherWayAround(int[] array)
    {
        int[] Array = new int[array.Length];
        int i = 0;
        for (int x = array.Length - 1; x >= 0; x--)
        {
            Array[i] = array[x];
            i++;
        }
        return Array;
    }
    public static int[] SortInAscendingOrder(int[] array, int length)
    {
        int[] Array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Array[i] = array[i];
        }
        for (int x = 0; x < Array.Length; x++)
        {
            for (int y = 1; y < Array.Length - 1; y++)
            {
                if (Array[x] > Array[y])
                {
                    int temp = Array[x];
                    Array[x] = Array[y];
                    Array[y] = temp;
                }
            }
        }
        return Array;
    }
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
    public static bool ArrayContainsNumber(int[] m1, int value)
    {
        bool IsContained = false;

        for (int i = 0; i < m1.Length; i++)
        {
            if (m1[i] == value)
            {
                IsContained = true;
                break;
            }
        }
        return IsContained;

    }
}
