using System;

namespace InheritanceOfGeneralizedTypes
{
    class C1
    {
        static void F1()
        {
            C2<string> obj1 = new C2<string>("10");
            C2<int> obj2 = new C3<int>(11);
            C3<int> obj3 = new C3<int>(12);
            Console.WriteLine(obj1.c1);
            Console.WriteLine(obj3.c1);
            Console.WriteLine(obj2.c1);

            C4 obj4 = new C4("13");
            C2<string> obj5 = new C4("14");
            Console.WriteLine(obj4.c1);
            Console.WriteLine(obj5.c1);
        }
    }

    class C2<T>
    {
        public T c1 { get; private set; }
        public C2(T c1)
        {
            this.c1 = c1;
        }
    }

    class C3<T> : C2<T>
    {
        public C3(T c1) : base(c1)
        {

        }
    }

    class C4 : C2<string>
    {
        public C4(string c1) : base(c1)
        {
        }
    }
}