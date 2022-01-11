using System;

namespace Lambdas
{
    class C1
    {
        delegate void Numb();
        delegate void Sum1(int x, int y);
        delegate int Sum2(int x, int y);
        delegate bool Sum3(int a);
        static void F1()
        {
            Numb numb1 = () => Console.WriteLine("10");
            numb1();

            Numb numb2 = () =>
            {
                Console.WriteLine("20");
                Console.WriteLine("30");
            };
            numb2();

            Sum1 sum1 = (a, b) => Console.WriteLine($"{a} + {b} = {a + b}");
            sum1(15, 30);

            Sum2 sum2 = (a, b) => a * b;
            int sumRes = sum2(10, 33);
            Console.WriteLine(sumRes);


            int[] arr1 = { 10, 33, 19, 24, 68, 44, 57, 60, 11 };

            int res1 = Sum(arr1, x => x > 24);
            Console.WriteLine(res1);

            int res2 = Sum(arr1, x => x % 2 == 0);
            Console.WriteLine(res2);

            int Sum(int[] numb, Sum3 func)
            {
                int res = 0;
                foreach (int i in numb)
                {
                    if (func(i))
                        res += i;
                }
                return res;
            }
        }
    }
}