using System;
using System.Threading;

namespace Monitors
{
    class C1
    {
        int n1 = 0;
        object locker = new object();
        static void F1()
        {
            for (int x = 1; x < 4; x++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {x}";
                myThread.Start();
            }
        }

        void Print()
        {
            bool acquiredLock = false;
            try
            {
                Monitor.Enter(locker, ref acquiredLock);
                n1 = 1;
                for (int y = 1; y < 4; y++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {n1}");
                    n1++;
                    Thread.Sleep(100);
                }
            }
            finally
            {
                if (acquiredLock) Monitor.Exit(locker);
            }
        }
    }
}