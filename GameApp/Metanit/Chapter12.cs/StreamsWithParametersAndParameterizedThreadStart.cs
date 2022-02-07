using System;
using System.Threading;



namespace StreamsWithParametersAndParameterizedThreadStart
{
    class C1
    {
        // public delegate void ParameterizedThreadStart(object obj);
        static void F1(string[] args)
        {
            Thread myThread1 = new Thread(new ParameterizedThreadStart(F2));
            Thread myThread2 = new Thread(F2);
            Thread myThread3 = new Thread(message => Console.WriteLine(message));

            myThread1.Start("Heloo");
            myThread2.Start("Привет");
            myThread3.Start("Salut");


        }
        public static void F2(object message) => Console.WriteLine(message);
    }
}