using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 p1 = new Person1();
            p1.Move();
            p1.Eat();

            Person2 p2 = new Person2();
            p2.DoSomething();
        }
    }
}