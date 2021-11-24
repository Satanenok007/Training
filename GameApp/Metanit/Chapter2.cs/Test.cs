using System;

namespace Test
{
    class C1
    {
        static void F1()
        {
            int[,] arr1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int rows = arr1.GetUpperBound(0) + 1;
            int columns = arr1.Length / rows;

            char[,] arr2 = new char[,] { { '1', '1', '1' }, { '2', '2', '2' } };
            int rows2 = arr2.GetUpperBound(0) + 1;
            int columns2 = arr2.Length / rows2;

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    Console.Write(arr1[y, x]);
                }
                Console.WriteLine();
                Console.Write("rows");
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int y2 = 0; y2 < rows2; y2++)
            {
                for (int x2 = 0; x2 < columns2; x2++)
                {
                    Console.Write(arr2[y2, x2]);
                }
                Console.WriteLine();
                Console.Write("rows");
                Console.WriteLine();
            }
        }
    }
}