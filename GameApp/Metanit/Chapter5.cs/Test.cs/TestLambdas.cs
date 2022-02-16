using System;

namespace TestLambdas
{
    class C1
    {
        delegate void delegate1();
        delegate void delegate2(int a, int b);
        delegate int delegate3(int a, int b);

        delegate bool delegate4(int x);
        static void F1()
        {
            delegate1 del1 = () => Console.WriteLine("l1");
            del1();
            delegate1 del2 = () =>
            {
                Console.WriteLine("l2");
                Console.WriteLine("l2");
            };
            del2();

            delegate2 del3 = (int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
            del3(10, 5);

            delegate3 sum = (int a, int b) => a + b;
            int res = sum(22, 1);
            Console.WriteLine(res);

            delegate3 subtract = (int a, int b) =>
            {
                if (a < b)
                {
                    return b - a;
                }
                else
                {
                    return a - b;
                }
            };

            delegate1 del4 = () => Console.WriteLine("10");
            delegate1 del5 = () => Console.WriteLine("20");
            del5 += () => Console.WriteLine("30");
            del5 += del4;
            del5 += F2;
            del5();
            void F2() => Console.WriteLine("40");


            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int res1 = Sum(array1, x => x > 5);
            Console.WriteLine(res1);

            int res2 = Sum(array1, x => x % 2 == 0);
            Console.WriteLine(res2);

            int Sum(int[] numb, delegate4 del4)
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