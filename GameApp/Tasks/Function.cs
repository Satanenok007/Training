using System;

static class Function
{
    public static int[] WriteValuesLessThanTheSpecifiedValue(int[] array, int number)
    {
        int[] result = new int[array.Length];
        int iterationResult = 0;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] < number)
            {
                result[iterationResult] = array[x];
                iterationResult++;
            }
        }
        int[] copyResult = Function.ArrayWithoutZeros(result);
        return copyResult;
    }
    public static int[] WriteValuesGreaterThanTheSpecifiedValue(int[] array, int number)
    {
        int[] result = new int[array.Length];
        int iterationResult = 0;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] > number)
            {
                result[iterationResult] = array[x];
                iterationResult++;
            }
        }
        int[] copyResult = Function.ArrayWithoutZeros(result);
        return copyResult;
    }
    public static bool FindingTheKey(int[] array, int[] key)
    {
        bool contains = false;
        int iterationKey = 0;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] == key[iterationKey] && array[x + 1] == key[iterationKey + 1] && iterationKey < key.Length)
            {
                contains = true;
            }
        }
        return contains;
    }
    public static int[] SortingAndWritingTheLargestArrayNumbers(int[] array, int number)
    {
        int[] result = new int[number];
        int[] Array = SortInAscendingOrder(array, array.Length);
        for (int i = 0; i < number; i++)
        {
            bool isContaiend = IsArrayContainsNumber(result, array[i]);
            if (isContaiend == false)
            {
                result[i] = Array[i];
            }
        }
        return result;
    }
    public static int[] AaddToTheMix(int[] array)
    {
        Random rnd = new Random();
        for (int x = array.Length - 1; x >= 0; x--)
        {
            int random = rnd.Next(x);
            int temp = array[x];
            array[x] = array[random];
            array[random] = temp;
        }
        return array;
    }
    public static int[] AlternatelyWritingValues(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];
        for (int x = 0; x < array1.Length; x++)
        {
            result[x * 2] = array1[x];
            result[x * 2 + 1] = array2[x];
        }
        return result;
    }
    public static int[] FindingMismatchedValues(int[] array1, int[] array2)
    {
        int[] mismatches = new int[array1.Length];
        int iterationForMisMatchesArray1 = 0;

        for (int x = 0; x < array1.Length; x++)
        {
            for (int y = 0; y < array2.Length; y++)
            {
                if (iterationForMisMatchesArray1 < array1.Length)
                {
                    bool isNonContained = IsArrayContainsNumber(array2, array1[x]);
                    bool isDoesContained = IsArrayContainsNumber(mismatches, array1[x]);

                    if (isNonContained != true && isDoesContained != true)
                    {
                        mismatches[iterationForMisMatchesArray1] = array1[x];
                        iterationForMisMatchesArray1++;
                    }
                }
            }
        }
        int iterationForMisMatchesArray2 = iterationForMisMatchesArray1;
        for (int x = 0; x < array2.Length; x++)
        {
            for (int y = 0; y < array1.Length; y++)
            {
                bool isNonContained = IsArrayContainsNumber(array1, array2[x]);
                bool isDoesContained = IsArrayContainsNumber(mismatches, array2[x]);

                if (isNonContained != true && isDoesContained != true && iterationForMisMatchesArray2 < mismatches.Length)
                {
                    mismatches[iterationForMisMatchesArray2] = array2[x];
                    iterationForMisMatchesArray2++;
                }
            }
        }
        int[] copyMismatches = ArrayWithoutZeros(mismatches);
        return copyMismatches;
    }
    public static int[] FindingMatchingNumbersInAnArray(int[] array1, int[] array2)
    {
        int[] repetitions = new int[array1.Length];
        int[] Result = new int[array1.Length];
        int y = 0;
        for (int x = 0; x < array1.Length; x++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[x] == array2[j] && y < array1.Length)
                {
                    bool isContaiend = IsArrayContainsNumber(repetitions, array1[x]);
                    if (isContaiend == false)
                    {
                        repetitions[y] = array1[x];
                        y++;
                    }
                }
            }
        }
        int[] copyArray = ArrayWithoutZeros(repetitions);
        return copyArray;
    }
    public static int ArithmeticMean(int[] array)
    {
        int amount = 0;
        int result;
        for (int i = 0; i < array.Length; i++)
        {
            amount = amount + array[i];
        }
        result = amount / array.Length;
        return result;
    }
    public static bool FindingAnArrayInAnArray(int[] array, int[] key)
    {
        bool result = false;
        int numberOfMatchingElements = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < key.Length; j++)
            {
                if (array[i] == key[j])
                {
                    numberOfMatchingElements++;
                }
            }
            continue;
        }
        if (numberOfMatchingElements == key.Length)
        {
            result = true;
        }
        return result;
    }
    public static int[] DuplicateElements(int[] array, int number)
    {
        int[] numberOfRepetitions = new int[array.Length];
        int y = 0;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] == number)
            {
                numberOfRepetitions[y] = x;
                y++;
            }
        }
        int[] copyArray = ArrayWithoutZeros(numberOfRepetitions);
        return copyArray;
    }
    public static int[] ArrayWithoutZeros(int[] array)
    {
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }

        int[] newArray = new int[n];
        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (j <= n - 1)
            {
                newArray[j] = array[i];
                j++;
            }
        }

        return newArray;
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
            for (int y = 0; y < Array.Length - 1; y++)
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
    public static bool IsArrayContainsNumber(int[] m1, int value)
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
}
