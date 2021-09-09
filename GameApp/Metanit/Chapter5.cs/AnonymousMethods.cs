using System;

namespace AnonymousMethods
{
    class Examlpe1
    {
        class Program
        {
            delegate void MessageHandler(string message);
            static void Main(string[] args)
            {
                MessageHandler handler = delegate (string mes)
                {
                    Console.WriteLine(mes);
                };
                handler("hello");

            }
        }
    }

    class Example2
    {
        class Program
        {
            delegate void MessageHandler(string message);
            static void Main(string[] args)
            {
                ShowMessage("hello)", delegate (string mes)
                {
                    Console.WriteLine(mes);
                });

            }
            static void ShowMessage(string mes, MessageHandler handler)
            {
                handler(mes);
            }
        }
    }

    class Example3
    {
        class Program
        {
            delegate void MessageHandler(string message);
            static void Main(string[] args)
            {
                MessageHandler handler = delegate
                {
                    Console.WriteLine("анонимный метод");
                };
                handler("hello");
            }
        }
    }

    class Example4
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation operation = delegate (int x, int y)
            {
                return x + y;
            };
            int d = operation(4, 5);
            Console.WriteLine(d);
        }
    }
}