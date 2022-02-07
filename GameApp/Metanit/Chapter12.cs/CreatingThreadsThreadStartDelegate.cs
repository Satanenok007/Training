using System;
using System.Threading;

namespace CreatingThreadsThreadStartDelegate
{
    class C1
    {
        static void F1()
        {
            Thread obj1 = new Thread(F2);
            Thread obj2 = new Thread(() => Console.WriteLine("1"));

            obj1.Start();
            obj2.Start();

            void F2() => Console.WriteLine("2");


            Thread obj3 = new Thread(F3);

            obj3.Start();

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"Главный поток: {x}");
                Thread.Sleep(300);
            }

            void F3()
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.WriteLine($"Второй поток: {y}");
                    Thread.Sleep(400);
                }
            }

            Thread obj4 = new Thread(F2);
            obj4.Start();
        }
    }
}