using System;
using System.Threading;

namespace IntroductionToMultithreadingThreadClass
{
    class C1
    {
        static void F1()
        {
            Thread currentThread = Thread.CurrentThread;

            Console.WriteLine($"Имя потока: {currentThread.Name}");
            currentThread.Name = "Метод Main";
            Console.WriteLine($"Имя потока: {currentThread.Name}");

            Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
            Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
            Console.WriteLine($"Статус потока: {currentThread.ThreadState}");


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }
    }
}