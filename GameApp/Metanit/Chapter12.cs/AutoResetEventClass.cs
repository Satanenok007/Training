using System;
using System.Threading;

namespace AutoResetEventClass
{
    class C1
    {
        static void F1()
        {
            int n1 = 0; 

            AutoResetEvent obj1 = new AutoResetEvent(true);

            for (int x = 1; x < 6; x++)
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
                obj1.Set();
            }
        }
    }
}