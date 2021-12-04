using System;

namespace Concealment
{
    class C1
    {
        static void F1(string args)
        {
            C2 cl2 = new C2(1, 2);
            cl2.Info();

            C3 cl3 = new C3(1, 2, 3);
            cl3.Info();

        }
    }

    class C2
    {
        public int c1 { get; set; }
        public int c2 { get; set; }
        public C2(int _c1, int _c2)
        {
            c1 = _c1;
            c2 = _c2;
        }

        public void Info()
        {
            Console.WriteLine($"c1: {c1}, c2: {c2}");
        }
    }

    class C3 : C2
    {
        public int c3 { get; set; }
        public C3(int c1, int c2, int c3)
        : base(c1, c2)
        {
            this.c3 = c3;
        }
        public new void Info()
        {
            Console.WriteLine($"c1: {c1}, c2: {c2}, c3: {c3}");
        }
    }

    class C4
    {
        protected int c4;
        public int c5
        {
            get { return c4; }
            set { c4 = value; }
        }
    }
    class C5 : C4
    {
        public new int c5
        {
            get { return base.c5; }
            set { c4 = value; }
        }
    }
}