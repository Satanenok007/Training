using System;

namespace CheckingdForNullOperators
{
    class C1
    {

        static void F1(string[] args)
        {
            string? s1 = null;
            s1 ??= "Hello";
            Console.WriteLine(s1);

            int? n1 = 1;
            n1 ??= 2;
            Console.WriteLine(n1);
        }
        void F2(C2? c2)
        {

            if (c2 != null && c2.C3 != null && c2.C3.C4 != null)
            {
                Console.WriteLine(c2.C3.C4.ToUpper());
            }
        }
    }

    class C2
    {
        public C3? C3 { get; set; }
    }
    class C3
    {
        public string? C4 { get; set; }
    }
}