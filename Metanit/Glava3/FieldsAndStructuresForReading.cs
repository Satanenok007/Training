using System;

namespace FieldsAndStructuresForReading
{
    class A
    {
        void Main()
        {
            B b1 = new B();
            b1.F1();
            C c1 = new C();
            c1.F2();
        }
    }

    class B
    {
        private readonly int b1 = 0;
        public B(int b1) => this.b1 = b1;
        public void F1(int b1) => Console.WriteLine(b1);
    }

    readonly struct C
    {
        private readonly int C1 { get; }
        private int C2 { get; }
        public C(int c1, int c2)
        {
            C1 = c1;
            C2 = c2;
        }
        public void F2(int c1) => Console.WriteLine(c1);
    }
}