using System;

namespace FieldsAndStructuresForReading
{
    class C1
    {
        static void F1()
        {
            C2 cl2 = new C2(12);
            cl2.Info();

            C3 st3 = new C3();
            Console.WriteLine(st3.n2);
            Console.WriteLine(st3.n3);

            C4 st4 = new C4(11, 24);
            Console.WriteLine(st4.n4);
            Console.WriteLine(st4.n5);
        }
    }

    class C2
    {
        public readonly int n1 = 10;
        public C2(int _n1)
        {
            _n1 = n1;
        }
        public void Info()
        {
            Console.WriteLine($"n1: {n1}");
        }
    }
    struct C3
    {
        public readonly int n2 { get; }
        public int n3 { get; }
        public C3(int n2, int n3)
        {
            this.n2 = n2;
            this.n3 = n3;
        }
    }

    class C4
    {
        public readonly int n4 = 10;
        public int n5 { get; }
        public C4(int n4, int n5)
        {
            this.n4 = n4;
            this.n5 = n5;
        }
        public void Info()
        {
            Console.WriteLine($"n4: {n4}");
        }
    }
}