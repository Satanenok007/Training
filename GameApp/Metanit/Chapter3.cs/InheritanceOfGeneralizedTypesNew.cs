using System;

namespace InheritanceOfGeneralizedTypes
{
    class C1
    {
        static void F1(string[] args)
        {
            C2<string> obj1 = new C2<string>("1");
            Console.WriteLine(obj1.N1);

            C3<int> obj2 = new C3<int>(12);
            Console.WriteLine(obj2.N1);

            C2<string> obj3 = new C3<string>("123");
            Console.WriteLine(obj3.N1);

            C4<string, int> obj4 = new C4<string, int>("1234") { Code = 1234 };
            Console.WriteLine(obj4.N1);

            C2<string> obj5 = new C4<string, int>("12345") { Code = 12345 };
            Console.WriteLine(obj5.N1);
        }
    }

    class C2<T>
    {
        public T N1 { get; private set; }
        public C2(T n1)
        {
            N1 = n1;
        }
    }

    class C3<T> : C2<T>
    {
        public C3(T n1) : base(n1)
        {
        }
    }

    class C4<T, A> : C2<T>
    where A : struct
    {
        public A Code { get; set; }
        public C4(T n1) : base(n1)
        {

        }
    }
}