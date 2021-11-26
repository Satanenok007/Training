using System;

namespace LocalFunction
{
    class C1
    {
        void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 11, 19, 10, 20, 17 };

            F2(arr1, arr2);
        }

        void F2(int[] array1, int[] array2)
        {
            int arr1F3 = F3(array1);
            int arr2F3 = F3(array2);

            if (arr1F3 > arr2F3)
            {
                Console.WriteLine("sum arr1 > arr2");
            }
            else
            {
                Console.WriteLine("sum arr1 < arr2");
            }

            int F3(int[] array)
            {
                int res = 0;
                foreach (int number in array)
                {
                    res += number;
                }
                return res;
            }
        }
    }
}