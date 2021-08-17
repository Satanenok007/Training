using System;

namespace AnonymousMethods
{
    class Program
    {
        delegate void MessageHandler(string message);
        static void Main(string[] args)
        {
            ShowMessage("hello!", delegate (string mes)
            {
                Console.WriteLine(mes);
            });
        }
        static void ShowMessage(string mes, MessageHandler handler)
        {
            handler(mes);
        }


        delegate int Operation(int x, int y);
        static void Mains(string[] args)
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