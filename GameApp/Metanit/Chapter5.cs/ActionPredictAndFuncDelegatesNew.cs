using System;

namespace ActionPredictAndFuncDelegates
{
    class C1
    {
        public delegate void d1();
        public delegate void d2<in T>(T obj);
        delegate bool d3<in T>(T obj);
        static void F1()
        {
            DoOperation(10, 6, Add);
            DoOperation(10, 6, Multiply);

            void DoOperation(int a, int b, Action<int, int> op) => op(a, b);

            void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
            void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");


            d3<int> isPositive = (int x) => x > 0;
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));
        }
    }
}