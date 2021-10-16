using System;

namespace Lambdas
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate int Square(int x);

        delegate void Hello();

        delegate void ChangeHandler(ref int x);

        delegate void World();
        static void MainLambdas(string[] args)
        {
            Operation operation = (x, y) => x + y;
            Console.WriteLine(operation(10, 20));
            Console.WriteLine(operation(40, 20));

            Square square = i => i * i;
            int z = square(6);
            Console.WriteLine(z);

            Hello hello1 = () => Console.WriteLine("Hello");
            Hello hello2 = () => Console.WriteLine("Welcome");
            hello1();
            hello2();


            int x = 9;
            ChangeHandler ch = (ref int n) => n = n * 2;
            ch(ref x);
            Console.WriteLine(x);


            Hello message = () => Show_Message();
            message();
            static void Show_Message()
            {
                Console.WriteLine("Привет мир!");
            }
        }

        static void Examplew2(string[] args)
        {
            Operation operation = (x, y) => x + y;
            Console.WriteLine(operation(10, 20));
            Console.WriteLine(operation(40, 20));

            Square square = i => i * i;
            int z = square(6);
            Console.WriteLine(z);

            Hello h1 = () => Console.WriteLine("Hello");
            Hello h2 = () => Console.WriteLine("Welcome");
            h1();
            h2();


            int x = 9;
            ChangeHandler ch = (ref int n) => n = n * 2;
            ch(ref x);
            Console.WriteLine(x);


            Hello mes = () => Message();
            mes();
            static void Message()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }

    class LambdasMethods
    {
        class Program
        {
            delegate bool IsEqual(int x);

            static void MainLambdasMethods(string[] args)
            {
                int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                int result1 = Sum(integers, x => x > 5);
                Console.WriteLine(result1);

                int result2 = Sum(integers, x => x % 2 == 0);
                Console.WriteLine(result2);
            }

            private static int Sum(int[] numbers, IsEqual func)
            {
                int result = 0;
                foreach (int i in numbers)
                {
                    if (func(i))
                    {
                        result += i;
                    }
                }
                return result;
            }
        }
    }
}