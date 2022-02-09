using System;
using System.Threading;

namespace Semaphores
{
    class C1
    {
        static void F1()
        {
            for (int i = 1; i < 6; i++)
            {
                User reader = new User(i);
            }
        }
    }

    class User
    {
        static Semaphore obj1 = new Semaphore(3, 3);
        Thread obj2;
        int count = 3;

        public User(int n1)
        {
            obj2 = new Thread(Website);
            obj2.Name = $"User {n1}";
            obj2.Start();
        }

        public void Website()
        {
            while (count > 0)
            {
                obj1.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} goes to the site");

                Console.WriteLine($"{Thread.CurrentThread.Name} orders");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} closes the page");

                obj1.Release();

                count--;
                Thread.Sleep(1000);
            }
        }
    }
}