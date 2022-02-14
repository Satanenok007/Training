using System;

namespace DelegateTest
{
    class C1
    {
        delegate void delegate1();
        delegate int delegate2(int x, int y);
        delegate void delegate3();
        delegate A delegate4<A, B>(B val);
        static void F1()
        {
            delegate1 d1;
            d1 = F2;
            d1 += F3;
            d1 -= F2;
            d1();
            void F2() => Console.WriteLine("f2");
            void F3() => Console.WriteLine("f3");

            delegate2 d2 = F4;
            delegate2 del2 = new delegate2(F4);
            int result = d2.Invoke(11, 9);
            int res = d2(4, 5);
            int F4(int x, int y) => x + y;
            int F5(int a, int b) => a * b;

            delegate3 d3 = F2;
            d3.Invoke();
            delegate3 del3 = F3;
            delegate3 res2 = d3 + del3;
            res2();

            delegate4<int, int> d4 = F7;
            int res3 = d4(3);
            Console.WriteLine(res3);
            int F7(int a) => a * a;

            Result(3, 4, F4);
            Result(5, 6, F5);

            void Result(int a, int b, delegate2 d2)
            {
                Console.WriteLine(d2(a, b));
            }
        }
    }
}