using System;
using System.Threading;

namespace SynchronizationOfStreams
{
    class C1
    {
        int n1 = 0;
        object locker = new object();
        static void F1()
        {
            for (int x = 0; x < 4; x++)
            {
                Thread obj1 = new Thread(F2);
                obj1.Name = $"Поток {x}";
                obj1.Start();
            }
        }

        void F2()
        {
            lock (locker)
            {
                n1 = 1;
                for (int y = 0; y < 4; y++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {y}");
                    y++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}