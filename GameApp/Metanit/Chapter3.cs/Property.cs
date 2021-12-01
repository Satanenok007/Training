using System;

namespace Proterty
{
    class C1
    {
        static void F1()
        {
            C2 cl2 = new C2();
            Console.WriteLine(cl2.n1);
            cl2.n1 = 40;
            Console.WriteLine(cl2.n1);

            C3 cl3 = new() { n4 = 12 };
            Console.WriteLine(cl3.n4);

            C4 cl4 = new C4();
            cl4.n5 = 13;
            Console.WriteLine(cl4.n5);
        }
    }

    class C2
    {
        public int n1 = 18;
        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                if (value < 18 || value > 30)
                {
                    Console.WriteLine("Неподходящее число");
                }
                else
                {
                    n1 = value;
                }
            }
        }
    }

    class C3
    {
        public int n2 { get; private set; }
        public int n3 { get; set; } = 12;
        public int n4 { get; init; }
    }

    class C4
    {
        public int n5;
        public int N5
        {
            get => n5;
            set => value = n5;
        }
    }
}