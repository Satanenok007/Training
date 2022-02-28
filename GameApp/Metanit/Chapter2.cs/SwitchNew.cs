using System;

namespace Switch
{
    class A
    {
        static void Main()
        {
            B b1 = new B();
            int n1 = 2;
            b1.F1(n1);
            Console.WriteLine();

            // int res1 = b1.F2(2, 10, 22);
            // Console.WriteLine($"res1: {res1}");
            // int res2 = b1.F2(1, 10, 2);
            // Console.WriteLine($"res2: {res2}");

            // int res3 = b1.F2(2, 11, 1);
            // Console.WriteLine($"res3: {res3}");
            // int res4 = b1.F2(1, 10, 2);
            // Console.WriteLine($"res4: {res4}");
        }
    }

    class B
    {
        public void F1(int n1)
        {
            switch (n1)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                default:
                    Console.WriteLine("Undefaind");
                    break;
            }
        }

        public int F2(int n1, int a, int b)
        {
            switch (n1)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a / b;
                default: return 0;
            }
        }

        int F3(int n1, int a, int b)
        {
            return n1 switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                _ => 0
            };
        }
    }
}