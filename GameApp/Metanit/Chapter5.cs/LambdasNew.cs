using System;

namespace Lambdas
{
    class C1
    {
        delegate void Delegate1();
        delegate void Delegate2(int a, int b);
        delegate int Delegate3(int a, int b);
        delegate bool Delegate4(int a);
        static void F1()
        {
            Delegate1 del1 = () => Console.WriteLine("l1");
            // var del2 = () => Console.WriteLine("l1");
            Delegate1 del3 = () =>
            {
                Console.WriteLine("l2");
                Console.WriteLine("l2");
            };
            del1();
            del3();

            Delegate2 del2 = (int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
            del2(11, 9);

            Delegate3 sum = (int a, int b) => a + b;
            int res = sum(2, 90);
            Console.WriteLine(res);

            Delegate3 subtract = (int a, int b) =>
            {
                if (a > b)
                {
                    return a - b;
                }
                else
                {
                    return b - a;
                }
            };

            Delegate1 del4 = () => Console.WriteLine("1");
            Delegate1 del5 = () => Console.WriteLine('2');
            del5 += () => Console.WriteLine("3");
            del5 += del4;
            del5 += F2;
            del5();
            void F2() => Console.WriteLine("4");

            int[] array1 = { 10, 20, 1, 5, 3, 4, 33, 11, 23 };

            int res1 = Sum(array1, x => x > 5);
            Console.WriteLine(res1);

            int res2 = Sum(array1, x => x % 2 == 0);
            Console.WriteLine(res2);

            int Sum(int[] numb, Delegate4 del4)
            {
                int result = 0;
                foreach (int i in numb)
                {
                    if (del4(i))
                    {
                        result += i;
                    }
                }
                return result;
            }
        }
    }
}