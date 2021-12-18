using System;

namespace LimitationsOfGeneralizations
{
    class C1
    {
        static void F1()
        {
            C2<int> obj1 = new C2<int>(1111) { c2 = 10000 };
            C2<int> obj2 = new C2<int>(1112) { c2 = 40000 };
            C3<C2<int>> obj3 = new C3<C2<int>>
            {
                c3 = obj1,
                c4 = obj2,
                c5 = 12000
            };
            obj3.F2();
        }
    }

    class C2<T>
    {
        public T c1 { get; private set; }
        public int c2 { get; set; }
        public C2(T c1)
        {
            this.c1 = c1;
        }
    }
    class C3<T> where T : C2<int>
    {
        public T c3 { get; set; }
        public T c4 { get; set; }
        public int c5 { get; set; }

        public void F2()
        {
            if (c3.c2 > c5)
            {
                c3.c2 -= c5;
                c4.c2 += c5;
                Console.WriteLine($"{c3.c1}: {c3.c2}, {c4.c1}: {c4.c2} (+12000)");
            }
            else
            {
                Console.WriteLine($"{c4.c1} > {c3.c1}");
            }
        }
    }
}