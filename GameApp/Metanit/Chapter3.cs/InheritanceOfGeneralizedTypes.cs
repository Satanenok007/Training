using System;

namespace InheritanceOfGeneralizedTypes
{
    class C1
    {
        static void F1()
        {
            C2<string> acc1 = new C2<string>("1");
            C2<int> acc3 = new C3<int>(2);
            C3<int> acc2 = new C3<int>(3);
            Console.WriteLine(acc1.N1);
            Console.WriteLine(acc2.N1);
            Console.WriteLine(acc3.N1);

            C4 acc4 = new C4("123");
            C2<string> acc5 = new C4("1234");
            Console.WriteLine(acc4.N1);
            Console.WriteLine(acc5.N1);
        }
    }

    class C2<T>
    {
        public T N1 { get; private set; }
        public C2(T _n1)
        {
            N1 = _n1;
        }
    }

    class C3<T> : C2<T>
    {
        public C3(T n1) : base(n1)
        {

        }
    }

    class C4 : C2<string>
    {
        public C4(string n1) : base(n1)
        {
        }
    }
}