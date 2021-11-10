using System;

namespace LimitationsOfGeneralization
{
    class Program
    {
        private static void F1(string[] args)
        {
            C1<int> obj1 = new C1<int>(123) { N2 = 1111 };
            C1<int> obj2 = new C1<int>(1234) { N2 = 2222 };

            C2<C1<int>> f4 = new C2<C1<int>>
            {
                N3 = obj1,
                N4 = obj2,
                N5 = 12345
            };
            f4.F2();
        }
    }
    class C1<T>
    {
        public T N1 { get; private set; }
        public int N2 { get; set; }
        public C1(T n1)
        {
            N1 = n1;
        }
    }
    class C2<T> where T : C1<int>
    {
        public T N3 { get; set; }
        public T N4 { get; set; }
        public int N5 { get; set; }

        public void F2()
        {
            if (N3.N2 > N5)
            {
                N3.N2 -= N5;
                N4.N2 += N5;
                Console.WriteLine($"C2 {N3.N1}: {N3.N2}$ \nC2 {N4.N1}: {N4.N2}$");
            }
            else
            {
                Console.WriteLine($"N2 < {N3.N1}");
            }
        }
    }

    class LimitationsOfMethods
    {
        private static void F2(string[] args)
        {
            C1<int> obj3 = new C1<int>(123) { N2 = 1111 };
            C1<int> obj4 = new C1<int>(1234) { N2 = 2222 };

            F3<C1<int>>(obj3, obj4, 123456);
        }

        public static void F3<T>(T obj3, T obj4, int n2) where T : C1<int>
        {
            if (obj3.N2 > n2)
            {
                obj3.N2 -= n2;
                obj4.N2 += n2;
            }
            Console.WriteLine($"obj3: {obj3.N2}   obj4: {obj4.N2}");
        }
    }
}