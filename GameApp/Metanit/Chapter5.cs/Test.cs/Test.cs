using System;

namespace TestD
{
    delegate void delegate1();
    delegate int delegate2(int x, int y);
    class C1
    {
        static void F1()
        {
            delegate1 d1 = F2;
            d1 += F3;
            d1 += F2;
            d1 -= F2;
            d1();

            delegate2 d2 = F4;
            int res = d2(2, 3);
            Console.WriteLine(res);
            
            void F2() => Console.WriteLine("1");
            void F3() => Console.WriteLine("1");
            int F4(int x, int y) => x + y;
        }
    }
}