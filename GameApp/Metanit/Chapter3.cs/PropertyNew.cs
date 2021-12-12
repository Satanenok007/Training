using System;

namespace Property
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2();
            Console.WriteLine(obj1.n1);
            obj1.n1 = 1;
            Console.WriteLine(obj1.n1);

            C2 obj2 = new() { n2 = 15 };
            Console.WriteLine(obj2.n2);
        }
    }

    class C2
    {
        public int n1 { get; set; }
        public int n2 { get; set; } = 0;
        public int n3 { get; internal set; }
        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                if (value > 10)
                {
                    n1 = value;
                }
                else
                {
                    Console.WriteLine("число больше 10");
                }
            }
        }
        public int N2
        {
            get => n2;
            set => value = n2;
        }
    }
}