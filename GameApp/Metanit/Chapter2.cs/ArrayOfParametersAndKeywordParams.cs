using System;

namespace ArrayOfParametersAndKeywordParams
{
    class ArrayOfParametersAndKeywordParams
    {
        static void F18()
        {
            Array(1, 2, 3, 4);
            int[] m1 = new int[] { 1, 2, 3, 4 };
            Array(m1);
            
            Array();
        }

        static void Array(params int[] m1)
        {
            int result = 0;
            for (int x = 0; x < m1.Length; x++)
            {
                result += m1[x];
            }
            Console.WriteLine(result);
        }
    }
}