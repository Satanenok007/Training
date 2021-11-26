using System;

namespace KeywordParams
{
    class C1
    {
        static void F1()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            F2(100, array1);
            F2(1, 2, 3);
            F2(10);
        }

        static void F2(int v1, params int[] array)
        {
            int res = v1;
            foreach (var x in array)
            {
                res += x;
            }
            Console.WriteLine(res);
        }
    }
}