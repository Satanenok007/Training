using System;

namespace ActionPredictAndFuncDelegates
{
    class Program
    {
        class Action
        {
            public delegate void Actions<T>(T obj);
            static void Main(string[] args)
            {
                Action<int, int> op;
                op = Add;
                Operation(10, 6, op);
            }

            static void Operation(int x1, int x2, Action<int, int> op)
            {
                if (x1 > x2)
                {
                    op(x1, x2);
                }
            }

            static void Add(int x1, int x2)
            {
                Console.WriteLine("Сумма чисел: " + (x1 + x2));
            }


            static void Mains(string[] args)
            {
                Action<double, double> actiondelegate;
                actiondelegate = Sum;
                Operation(11.88, 6.55, actiondelegate);
                actiondelegate = Substract;
                Operation(100.22, 9.64, actiondelegate);
                Console.Read();
            }

            static void Operation(double a, double b, Action<double, double> actiondelegate)
            {
                if (a > b)
                    actiondelegate(a, b);
            }

            static void Sum(double a, double b)
            {
                Console.WriteLine("Сумма чисел: " + (a + b));
            }

            static void Substract(double a, double b)
            {
                Console.WriteLine("Разность чисел: " + (a - b));
            }
        }

        class Predict
        {
            static void Main(string[] args)
            {
                Predicate<int> isPositive = delegate (int x) { return x > 0; };
                Console.WriteLine(isPositive(20));
                Console.WriteLine(isPositive(-20));
            }


            
        }

        class Func
        {
            static void Main(string[] args)
            {
                Func<int, int> retFunc = Factorial;
                int n1 = GetInt(6, retFunc);
                Console.WriteLine(n1);

                int n2 = GetInt(6, x => x * x);
                Console.WriteLine(n2);
            }

            static int GetInt(int x1, Func<int, int> retF)
            {
                int result = 0;
                if (x1 > 0)
                {
                    result = retF(x1);
                }
                return result;
            }
            static int Factorial(int x)
            {
                int result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }

        }


    }
}