using System;

namespace Tests
{
    class C1
    {
        static void F1()
        {
            C2 obj1 = new C2(10, 11);
            obj1.F1();

            C3 obj2 = new C3();
            Console.WriteLine(obj2.n3);
            obj2.n3 = 1;
            Console.WriteLine(obj2.n3);

            C3 obj3 = new() { n4 = 2 };
            Console.WriteLine(obj2.n4);
        }
    }

    class C2
    {
        public int n1;
        public int n2;
        public C2(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void F1()
        {
            Console.WriteLine($"n1: {n1}, n2: {n2}");
        }
    }

    class C3
    {
        public int n3 { get; set; }
        public int n4 { get; set; } = 0;
        public int n5 { get; protected set; }
        public int N3
        {
            get
            {
                return n3;
            }
            set
            {
                if (value > 10)
                {
                    n3 = value;
                }
                else
                {
                    Console.WriteLine("число больше 10");
                }
            }
        }
        public int N4
        {
            get => n4;
            set => value = n4;
        }
    }
}