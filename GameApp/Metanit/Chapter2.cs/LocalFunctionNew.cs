using System;

namespace LocalFunction
{
    class A
    {
        static void F()
        {
            B b1 = new B();

            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 4, 5, 6 };
            b1.F1(arr1, arr2);
            Console.WriteLine();

            int[] arr3 = new int[] { 1, 2, 3 };
            int[] arr4 = new int[] { 1, 2, 3 };
            b1.F1(arr3, arr4);
            Console.WriteLine();

            int[] arr5 = new int[] { 9, 10, 7 };
            int[] arr6 = new int[] { 1, 2, 3 };
            b1.F1(arr5, arr6);
            Console.WriteLine();
        }
    }

    class B
    {
        public void F1(int[] arr1, int[] arr2)
        {
            int n1 = F2(arr1);
            int n2 = F2(arr2);

            if (n1 > n2)
            {
                Console.WriteLine("arr1 > arr2");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("arr1 < arr2");
            }
            else
            {
                Console.WriteLine("arr1 = arr2");
            }

            int F2(int[] numb)
            {
                int res = 0;
                foreach (int i in numb)
                {
                    res += i;
                }
                return res;
            }
        }
    }
}