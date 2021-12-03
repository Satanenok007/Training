using System;

namespace TypeConversoin
{
    class C1
    {
        static void F1(string[] args)
        {
            C3 cl1 = new C3("c1", "c2");
            C2 cl2 = cl1;
            Console.WriteLine(cl2.n1);

            object cl3 = new C3("c1", "c2");
            ((C2)cl3).Info();
            Console.WriteLine(cl3);

            C2 cl4 = new C3("c1", "c3");
            Console.WriteLine(cl4);

            C4 cl5 = (C4)cl4;
        }
    }
    class C2
    {
        public string n1 { get; set; }
        public C2(string _n1)
        {
            n1 = _n1;
        }
        public void Info()
        {
            Console.WriteLine($"C1: {n1}");
        }
    }

    class C3 : C2
    {
        public string n2 { get; set; }
        public C3(string n1, string _n2) : base(n1)
        {
            n2 = _n2;
        }

    }
    class C4 : C2
    {
        public string n3 { get; set; }
        public C4(string c1, string _n3) : base(c1)
        {
            n3 = _n3;
        }
    }
}