using System;

namespace Concealments
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2(1, 2);
            obj1.F2();

            C3 obj2 = new C3(1, 2, 3);
            obj2.F2();
        }
    }

    class C2
    {
        public int n1;
        public int n2;

        public C2(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void F2()
        {
            Console.WriteLine($"{n1},{n2}");
        }
    }

    class C3 : C2
    {
        public int n3;
        public C3(int n1, int n2, int n3) : base(n1, n2)
        {
            this.n3 = n3;
        }
        public new void F2()
        {
            Console.WriteLine($"{n1}, {n2}, {n3}");
        }
    }
}