using System;

namespace Functions.FindArrayInArray
{
    public static class FindArray
    {
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
            return result;
        }
    }
}
