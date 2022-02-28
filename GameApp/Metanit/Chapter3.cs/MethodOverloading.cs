using System;

namespace MethodOverloading
{
    class A
    {
        void Main(string[] args)
        {
            B b1 = new B();
            b1.C(1, 2);
            b1.C(1, 2, 3);
            b1.C(1, 2, 3, 4);
        }
    }
    class B
    {
        public void C(int a, int b)
        {
            int res = a + b;
            Console.WriteLine($"res: {res}");
        }
        public void C(int a, int b, int c)
        {
            int res = a + b + c;
            Console.WriteLine($"res: {res}");
        }

        public void C(int a, int b, int c, int d)
        {
            int res = a + b + c + d;
            Console.WriteLine($"res: {res}");
        }
    }
}