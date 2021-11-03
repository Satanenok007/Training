using System;

namespace Inheritance
{
    class C1
    {
        public string n1 { get; set; }

        public C1(string _n1)
        {
            n1 = _n1;
        }

        public void Info()
        {
            Console.WriteLine(n1);
        }
    }

    class C2 : C1
    {
        public string n2 { get; set; }

        public C2(string n1, string _n2)
            : base(n1)
        {
            n2 = _n2;
        }
    }
    class C3
    {
        static void F1(string[] args)
        {
            C1 obj1 = new C1("n1");
            obj1.Info();
            C2 obj2 = new C2("n1", "n2");
            obj2.Info();
        }
    }
}