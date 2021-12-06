using System;

namespace LimitationsOfGeneralizations
{
    class C1
    {
        static void F1()
        {
            C2<int> obj1 = new C2<int>(1857) { n2 = 4500 };
            C2<int> obj2 = new C2<int>(3453) { n2 = 5000 };
            C3<C2<int>> obj3 = new C3<C2<int>>
            {
                n3 = obj1,
                n4 = obj2,
                n5 = 6900
            };
            obj3.F2();
        }
    }

    class C2<T>
    {
        public T n1 { get; private set; }
        public int n2 { get; set; }
        public C2(T _n1)
        {
            n1 = _n1;
        }
    }
    class C3<T> where T : C2<int>
    {
        public T n3 { get; set; }
        public T n4 { get; set; }
        public int n5 { get; set; }

        public void F2()
        {
            if (n3.n2 > n5)
            {
                n3.n2 -= n5;
                n4.n2 += n5;
                Console.WriteLine($"C {n3.n1}: {n3.n2}, на  {n4.n1}: {n4.n2} (+5)");
            }
            else
            {
                Console.WriteLine($"{n4.n1} > {n3.n1}");
            }
        }
    }
}