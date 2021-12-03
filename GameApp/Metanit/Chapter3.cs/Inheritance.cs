using System;

namespace Inheritance
{
    class C1
    {
        public int n1 { get; set; }

        public C1(int _n1)
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
        public int n2 { get; set; }

        public C2(int n1, int _n2)
            : base(n1)
        {
            n2 = _n2;
        }
    }
    class C3
    {
        static void F1(string[] args)
        {
            C1 cl1 = new C1(1);
            cl1.Info();
            C2 cl2 = new C2(1, 2);
            cl2.Info();
        }
    }
}