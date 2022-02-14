using System;

namespace Delegates
{
    class C1
    {
        delegate void Delegate1();
        delegate int Delegate2(int x, int y);
        delegate int Delegate3(int a, int b);
        delegate T Delegate4<T, K>(K val);
        delegate W Delegate5<W, L>(L val);

        delegate void Delegate4();
        static void F1()
        {
            Delegate1 d1;
            d1 = Info;
            d1 += Info2;
            d1 -= Info;
            d1();

            Delegate2 d2 = F2;
            int res = d2(4, 5);
            int result = d2.Invoke(11, 9);

            Delegate3 d3 = F3;
            Delegate3 del3 = new Delegate3(F3);
            int res2 = d3(10, 20);

            Delegate1 o1 = Info;
            Delegate1 o2 = Info2;
            Delegate1 o3 = o1 + o2;
            o3();

            Delegate4 d4 = Info;
            d4.Invoke();

            Delegate4<int, int> o4 = F4;
            int res3 = o4(2);
            Console.WriteLine(res3);

            Result(1, 2, F2);
            Result(3, 4, F3);

            void Info() => Console.WriteLine("Info");
            void Info2() => Console.WriteLine("Info2");
            int F2(int x, int y) => x + y;
            int F3(int a, int b) => a * b;
            int F4(int z) => z + z;
            void Result(int a, int b, Delegate3 delegate3)
            {
                Console.WriteLine(delegate3(a, b));
            }
        }
    }
}