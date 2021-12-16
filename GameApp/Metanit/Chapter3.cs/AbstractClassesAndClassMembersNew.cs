using System;

namespace AbstractClassesAndClassMembers
{
    class C1
    {
        static void F1(string[] args)
        {
            C3 obj1 = new C3(1, 2);
            obj1.Info();

            C2 obj2 = new C3(3, 4);
            obj2.Info();
        }
    }
    abstract class C2
    {
        public abstract int n1 { get; set; }
        public C2(int _n1)
        {
            n1 = _n1;
        }

        public abstract void Info();
    }

    class C3 : C2
    {
        public int n2 { get; set; }
        public override int n1
        {
            get { return n1; }
            set { n1 = value; }
        }
        public C3(int n1, int _n2)
        : base(n1)
        {
            n2 = _n2;
        }
        public override void Info()
        {
            Console.WriteLine($"n1: {n1}, n2: {n2}");
        }
    }
}