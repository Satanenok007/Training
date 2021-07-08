using System;

static class Function
{
    public static int[] CreatingAndPromotingASmileyFace(int verticalLength, int horizontalLength, int smilecoordinateY, int smilecoordinateX, int[] obstacles)
    {
        int[] smilecoordinate = new int[2];
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();
        char symbol = key.KeyChar;

        if (symbol == 's')
        {

            if (smilecoordinateY == obstacles[0] - 1 && smilecoordinateX == obstacles[1])
            {
            }
            else
            {
                if (smilecoordinateY < verticalLength - 2)
                {
                    smilecoordinateY++;
                }
            }
        }
        else if (symbol == 'w')
        {
            if (smilecoordinateY > 1)
            {
                if (smilecoordinateY == obstacles[0] + 1 && smilecoordinateX == obstacles[1])
                {
                }
                else
                {
                    smilecoordinateY--;
                }
            }
        }
        else if (symbol == 'd')
        {

            if (smilecoordinateY == obstacles[0] && smilecoordinateX == obstacles[1] - 1)
            {
            }
            else
            {
                if (smilecoordinateX < horizontalLength - 2)
                {
                    smilecoordinateX++;
                }
            }
        }
        else if (symbol == 'a')
        {
            if (smilecoordinateX > 1)
            {
                if (smilecoordinateY == obstacles[0] && smilecoordinateX == obstacles[1] + 1)
                {
                }
                else
                {
                    smilecoordinateX--;
                }
            }
        }
        smilecoordinate[0] = smilecoordinateY;
        smilecoordinate[1] = smilecoordinateX;
        return smilecoordinate;
    }

    public static void CreatingAnArrayWithBarriersAndASmileyFace(char[,] field, int verticalLength, int horizontalLength)
    {
        char[,] result = new char[verticalLength, horizontalLength];
        int smilecoordinateX = 1;
        int smilecoordinateY = 1;
        int[] obstacles = Function.CreatingObstacles(verticalLength, horizontalLength);

        while (true)
        {
            int[] smilecoordinate = Function.CreatingAndPromotingASmileyFace(verticalLength, horizontalLength, smilecoordinateY, smilecoordinateX, obstacles);
            smilecoordinateY = smilecoordinate[0];
            smilecoordinateX = smilecoordinate[1];

            for (int y = 0; y < verticalLength; y++)
            {
                for (int x = 0; x < horizontalLength; x++)
                {
                    if (y == 0 || y == verticalLength - 1)
                    {
                        result[y, x] = '▨';
                    }
                    else if (x == 0 || x == horizontalLength - 1)
                    {
                        result[y, x] = '▨';
                    }
                    else if (y == smilecoordinate[0] && x == smilecoordinate[1])
                    {
                        result[y, x] = '☹';
                    }
                    else if (y == obstacles[0] && x == obstacles[1])
                    {
                        result[y, x] = '▨';
                    }
                    else
                    {
                        result[y, x] = ' ';
                    }
                }
            }
            for (int y = 0; y < verticalLength; y++)
            {
                for (int x = 0; x < horizontalLength; x++)
                {
                    Console.Write(result[y, x]);
                }
                Console.WriteLine();
            }
        }
    }

    public static int[] CreatingObstacles(int verticalLength, int horizontalLength)
    {
        int[] barrier = new int[2];
        Random random = new Random();
        int barrierX = random.Next(1, horizontalLength - 2);
        int barrierY = random.Next(1, verticalLength - 2);

        barrier[0] = barrierY;
        barrier[1] = barrierX;

        return barrier;
    }
    public static int SearchForHare(int numberOfSteps, int jump)
    {
        int result = 0;
        if (jump <= numberOfSteps)
        {
            for (int j = 1; j <= numberOfSteps; j++)
            {
                result = 0;
                Console.Write(result);
            }
        }
        return result;
    }
    public static char[,] FindAKeyIATwoDimensionalArray(int[,] array, int[,] key, int ArrayXLenght, int ArrayYLenght, int keyLength1, int keyLength2)
    {
        char[,] resultArray = new char[ArrayYLenght, ArrayXLenght];

        if (keyLength1 <= ArrayYLenght && keyLength2 <= ArrayXLenght)
        {
            for (int y = 0; y < ArrayYLenght; y++)
            {
                for (int x = 0; x < ArrayXLenght; x++)
                {
                    for (int k = 0; k < keyLength1; k++)
                    {
                        for (int i = 0; i < keyLength2; i++)
                        {
                            if (x + i <= ArrayXLenght - 1 && array[y, x + i] == key[k, i])
                            {
                                if (i == keyLength2 - 1)
                                {
                                    for (int j = x; j < x + keyLength2; j++)
                                    {
                                        resultArray[y, j] = '*';
                                    }
                                }
                            }
                            else
                            {
                                if (resultArray[y, x] != '*')
                                {
                                    resultArray[y, x] = array[y, x].ToString()[0];
                                    break;
                                }
                            }
                        }

                    }
                }
            }
        }

        return resultArray;
    }
    public static string PrintTheStringTheSpecifiedNumberOfTimes(string line, int number)
    {
        string result = "";
        for (int x = 1; x <= number + 1; x++)
        {
            if (x < number + 1)
            {
                Console.Write(result = line + x + "|");
            }
            else
            {
                Console.Write(result = line + x);
            }
        }
        return result;
    }
    public static char[] FindAndPaintOverTheKey(int[] array, int[] key)
    {
        char[] result = new char[array.Length];
        for (int x = 0; x < array.Length; x++)
        {
            for (int y = 0; y < key.Length; y++)
            {
                if (x + y < array.Length - 1 && array[x + y] == key[y])
                {
                    if (y == key.Length - 1)
                    {
                        for (int i = x; i <= x + key.Length - 1; i++)
                        {
                            result[i] = '*';
                        }
                    }
                }
                else
                {
                    if (result[x] != '*')
                    {
                        result[x] = array[x].ToString()[0];
                        break;
                    }
                }
            }
        }
        return result;
    }
    public static int[] FindOnWhichIterationsTheKeyOccurs(int[] array, int[] key)
    {
        int[] result = new int[array.Length];
        int iterationResult = 0;
        for (int x = 0; x <= array.Length - key.Length; x++)
        {
            for (int y = 0; y < key.Length; y++)
            {
                if (array[x + y] == key[y])
                {
                    if (y == key.Length - 1)
                    {
                        result[iterationResult] = x;
                        iterationResult++;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        int[] copyResult = Function.ArrayWithoutZeros(result);
        return result;
    }
    public static bool FindingTheKey(int[] array, int[] key)
    {
        bool contains = false;
        int iteration = 0;
        for (int x = 0; x < array.Length; x++)
        {
            if (array.Length - x >= key.Length)
            {
                if (array[x] == key[iteration] && iteration < key.Length)
                {
                    contains = true;
                    iteration++;
                }
                else
                {
                    iteration = 0;
                    contains = false;
                    break;
                }
            }
        }
        return contains;
    }

    public static bool FindingAnArray(int[] array, int[] key, int number)
    {
        bool coincidence = false;
        int iteration = 0;
        if (array.Length - number >= key.Length)
        {
            for (int x = number; x < array.Length; x++)
            {
                if (array[x] == key[iteration] && iteration < key.Length)
                {
                    coincidence = true;
                    iteration++;
                }
                else
                {
                    coincidence = false;
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("the key length is longer than the array");
            Console.WriteLine();
        }
        return coincidence;
    }

    public static bool CompareTwoArrays(int[] array, int[] key)
    {
        bool coincidence = false;

        if (array.Length == key.Length)
        {
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] == key[x])
                {
                    coincidence = true;
                }
                else
                {
                    coincidence = false;
                    break;
                }
            }
        }
        return coincidence;
    }
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
    public static int[,] PrintTwoDimensionalArray(int[,] array, int yLength, int xLength)
    {
        for (int y = 0; y < yLength; y++)
        {
            for (int x = 0; x < xLength; x++)
            {
                Console.Write(array[y, x]);
            }
            Console.WriteLine();
        }
        return array;
    }

    public static char[,] PrintTwoDimensionalCharArray(char[,] array, int yLength, int xLength)
    {
        for (int y = 0; y < yLength; y++)
        {
            for (int x = 0; x < xLength; x++)
            {
                Console.Write(array[y, x]);
            }
            Console.WriteLine();
        }
        return array;
    }
}
