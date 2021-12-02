using System;

namespace MethodOverloading
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 cl2 = new C2();
            cl2.F2(1);
            cl2.F2(1, 2);
            cl2.F2(1, 2, 3);
        }
    }
    class C2
    {
        public void F2(int n1)
        {
            int result = n1;
            Console.WriteLine($"result : {result}");
        }
        public void F2(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine($"result : {result}");
        }
        public void F2(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
            Console.WriteLine($"result : {result}");
        }
    }
}