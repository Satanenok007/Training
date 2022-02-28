using System;

namespace PassingParametersByReferenceAndValueOutputParameters
{
    class A
    {
        static void F()
        {
            B b1 = new B();

            int n1 = 10;
            Console.WriteLine($"before F1: {n1}");
            b1.F1(n1);
            Console.WriteLine($"after F1: {n1}");
            Console.WriteLine();

            int n2 = 10;
            Console.WriteLine($"before F2: {n2}");
            b1.F2(ref n2);
            Console.WriteLine($"after F2: {n2}");
            Console.WriteLine();

            int res;
            b1.F3(20, 12, out res);
            Console.WriteLine($"F3: {res}");
            Console.WriteLine();

            int result;
            int a = 10;
            int b = 30;
            b1.F4(a, b, out result);
            Console.WriteLine($"F4: {result}");
            Console.WriteLine();
        }
    }

    class B
    {
        public void F1(int n)
        {
            n++;
            Console.WriteLine($"in the F1: {n}");
        }
        public void F2(ref int n)
        {
            n++;
            Console.WriteLine($"in the F2: {n}");
        }

        public void F3(int a, int b, out int res)
        {
            res = a - b;
        }

        public void F4(in int a, in int b, out int res)
        {
            res = a + b;
        }
    }
}