using System;
using System.Threading;

namespace Mutexes
{
    class C1
    {
        static void F1()
        {
            int n1 = 0;
            Mutex obj1 = new();

            for (int x = 1; x < 3; x++)
            {
                Thread obj2 = new(F2);
                obj2.Name = $"Поток {x}";
                obj2.Start();
            }

            void F2()
            {
                obj1.WaitOne();
                n1 = 1;
                for (int y = 1; y < 6; y++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {n1}");
                    n1++;
                    Thread.Sleep(100);
                }
                obj1.ReleaseMutex();
            }
        }
    }
}