using System;

namespace MethodOverloading
{
    class MethodOverloading
    {
        class C1
        {
            public void F1(int x, int y)
            {
                int res = x + y;
                Console.WriteLine($"result {res}");
            }
            public void F1(int x, int y, int z)
            {
                int res = x + y + z;
                Console.WriteLine($"result {res}");
            }
            public int F1(int x, int y, int z, int i)
            {
                int res = x + y + z + i;
                Console.WriteLine($"result {res}");
                return res;
            }
            public void F1(double x, double y)
            {
                double res = x + y;
                Console.WriteLine($"result {res}");
            }
        }
        static void F2()
        {

            C1 n1 = new C1();
            n1.F1(17, 30);
            n1.F1(19, 32, 22);
            n1.F1(10, 34, 48, 60);
            n1.F1(6.8, 3.5);
        }
    }
}