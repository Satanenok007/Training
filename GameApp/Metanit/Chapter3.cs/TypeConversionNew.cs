using System;

namespace TypeConversoin
{
    class C1
    {
        public string c1 { get; set; }
        public C1(string _c1)
        {
            c1 = _c1;
        }
        public void Info()
        {
            Console.WriteLine($"C1: {c1}");
        }
    }

    class C2 : C1
    {
        public string c2 { get; set; }
        public C2(string c1, string _c2) : base(c1)
        {
            c2 = _c2;
        }

    }
    class C3 : C1
    {
        public string c3 { get; set; }
        public C3(string c1, string _c3) : base(c1)
        {
            c3 = _c3;
        }
    }
    class C5
    {
        static void F1(string[] args)
        {
            C2 n1 = new C2("c1", "c2");
            C1 n2 = n1;
            Console.WriteLine(n2.c1);

            object n3 = new C2("c1", "c2");
            ((C1)n3).Info();
            Console.WriteLine(n3);

            C1 n4 = new C3("c1", "c3");
            Console.WriteLine(n4);

            C3 n5 = (C3)n4;
        }
    }
}