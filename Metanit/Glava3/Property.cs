using System;

namespace Property
{
    class A
    {
        static void Main() 
        {
            B b1 = new B() {n4 = 10};
            Console.WriteLine(b1.n1);
            b1.n2 = -1;
            Console.WriteLine(b1.n2);
            Console.WriteLine(b1.n3);
        }
    }

    class B
    {
        public int n1 = 10;
        public int n2 
        {
            set
            {
                if(n1 <= 0)
                {
                    Console.WriteLine("подходящее число");
                } else
                {
                    Console.WriteLine("число не подходит");
                }
            }
            get
            {
                return n1;
            }
        }
        public int n3 { get; private set; }
        public int n4 { get; init; } = 0;
    }
}