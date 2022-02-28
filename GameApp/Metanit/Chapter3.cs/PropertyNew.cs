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

            C3 cl3 = new() { N3 = 12 };
            Console.WriteLine(cl3.N3);

            C4 cl4 = new C4();
            cl4.N1 = 13;
            Console.WriteLine(cl4.N1);
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
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Число уже существует");
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
        public int N1{ get; private set; }
        public int N2 { get; set; } = 12;
        public int N3 { get; init; }
    }

    class C4
    {
        public int N1;
        public int N2
        {
            get => N1;
            set => value = N1;
        }
    }
}