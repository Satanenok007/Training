using System;

namespace ConstantsAndFieldsAndStructuresForReading
{
    class C1
    {
        public const int n1 = 10;
        public readonly int n2 = 100;
    
        public C1(int _n2)
        {
            n2 = _n2;
        }
    }

    struct C2
    {
        public readonly int N1 { get; }
        public int N2 { get; }
        public C2(int n1, int n2)
        {
            this.N1 = n1;
            this.N2 = n2;
        }
    }

    class C3
    {
        static void F1(string[] args)
        {
            Console.WriteLine(C1.n1);

            const int x = 12;
            Console.WriteLine(x);

            int res1 = C1.n1 + 10;
            Console.WriteLine(res1);

            C1 res2 = new C1(21);
            Console.WriteLine(res2.n2);
        }
    }
}