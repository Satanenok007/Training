using System;

namespace AnonymousMethods
{
    class Examlpe1
    {
        class Program
        {
            delegate void MessageHandler(string message);
            static void MainDel(string[] args)
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
            static void MainDel2(string[] args)
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
            static void MainDel3(string[] args)
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
        static void MainDel4(string[] args)
        {
            Operation operation = delegate (int x, int y)
            {
                return x + y;
            };
            int d = operation(4, 5);
            Console.WriteLine(d);
        }
    }

    class Ex1
    {
        class Option1
        {
            class Program
            {
                delegate void MessageHandler(string message);
                static void MainDel5(string[] args)
                {
                    MessageHandler handler = delegate (string mes)
                    {
                        Console.WriteLine(mes);
                    };
                    handler("Option1");

                }
            }
        }

        class Option2
        {
            class Program
            {
                delegate void MessageHandler(string message);
                static void MainOption2(string[] args)
                {
                    ShowMessage("Option2", delegate (string mes)
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

        class Option3
        {
            class Program
            {
                delegate void MessageHandler(string message);
                static void MainDel6(string[] args)
                {
                    MessageHandler handler = delegate
                    {
                        Console.WriteLine("анонимный метод");
                    };
                    handler("Option3");
                }
            }
        }

        class Option4
        {
            delegate int Operation(int x, int y);
            static void MainOption4(string[] args)
            {
                Operation operation = delegate (int x, int y)
                {
                    return x + y;
                };
                int sum = operation(16, 78);
                Console.WriteLine(sum);
            }
        }
    }
}