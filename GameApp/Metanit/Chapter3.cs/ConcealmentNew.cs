using System;
namespace Concealment
{
    class C1
    {
        public string N1 { get; set; }
        public string N2 { get; set; }
        public C1(string n1, string n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public void Info()
        {
            Console.WriteLine($"{N1} {N2}");
        }
    }

    class C2 : C1
    {
        public int N3 { get; set; }
        public C2(string n1, string n2, int n3)
                : base(n1, n2)
        {
            N3 = n3;
        }
        public new void Info()
        {
            Console.WriteLine($"{N1} {N2} живёт в {N3}");
        }
    }

    class C3
    {
        public readonly int x1 = 10;
        public const int x2 = 5;
    }

    class C4 : C3
    {
        public new readonly int x1 = 20;
        public new const int x2 = 15;
    }

    class C5
    {
        static void F1(string[] args)
        {
            C1 obj1 = new C1("Nikita", "Belarus");
            obj1.Info();

            C2 obj2 = new C2("Kate", "Smitt", 123);
            obj2.Info();
        }
    }
}