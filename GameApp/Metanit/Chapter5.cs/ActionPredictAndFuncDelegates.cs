using System;

namespace ActionPredictAndFuncDelegates
{
    class C1
    {
        public delegate void Action();
        public delegate void Action<in T>(T obj);
        delegate bool Predicate<in T>(T obj);
        void F1(string[] args)
        {
            DoOperation(10, 6, Add);
            DoOperation(10, 6, Multiply);

            Predicate<int> isPositive = (int x) => x > 0;
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));
        }


        void DoOperation(int a, int b, Action<int, int> op) => op(a, b);

        void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
        void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");
    }
}