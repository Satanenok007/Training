using System;

namespace ArrayOfParametersAndKeywordParams
{
    class A
    {
        static void F()
        {
            B b1 = new B();
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            b1.F1(arr1);
            b1.F1(1, 2, 3, 4);
            b1.F1(1, 2, 3);
            b1.F1();
            Console.WriteLine();

            int[] arr2 = new int[] { 10, 20, 30 };
            b1.F2(1, arr2);
            b1.F2(1, 2, 3);
            b1.F2(10);
        }
    }

    class B
    {
        public void F1(params int[] numb)
        {
            int res = 0;
            foreach (var n in numb)
            {
                res += n;
            }
            Console.WriteLine(res);
        }

        public void F2(int n1, params int[] numb)
        {
            int res = n1;
            foreach (var i in numb)
            {
                res += i;
            }
            Console.WriteLine(res);
        }
    }
}