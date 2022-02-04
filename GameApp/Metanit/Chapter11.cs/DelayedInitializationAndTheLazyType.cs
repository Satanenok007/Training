using System;

namespace DelayedInitializationAndTheLazyType
{
    class C1
    {
        static void F1()
        {
            C2 reader = new C2();
            reader.F3();
            reader.F2();
        }
    }

    class C2
    {
        Lazy<C3> obj1 = new Lazy<C3>();
        public void F2()
        {
            obj1.Value.F4();
            Console.WriteLine("we buy in the store");
        }

        public void F3()
        {
            Console.WriteLine("we order online");
        }
    }

    class C3
    {
        private string[] obj2 = new string[99];

        public void F4()
        {
            Console.WriteLine("we send the order to the buyer");
        }
    }
}