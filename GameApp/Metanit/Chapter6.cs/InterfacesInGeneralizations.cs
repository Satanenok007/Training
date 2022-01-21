using System;

namespace InterfacesInGeneralizations
{
    class C1
    {
        static void F1()
        {
            var obj1 = new C1<C2>();

            var obj2 = new C2("obj1");
            obj1.F3(obj2);

            I3<int> obj3 = new C2<int>(123);
            Console.WriteLine(obj3.O1);

            I3<string> obj4 = new C2<string>("obj2");
            Console.WriteLine(obj4.O1);
        }
    }

    interface I1
    {
        string S1 { get; }
    }
    interface I2
    {
        void F2();
    }
    class C2 : I1, I2
    {
        public string S1 { get; }
        public C2(string s1) => this.S1 = s1;

        public void F2() => Console.WriteLine(S1);
    }

    class C1<T> where T : I1, I2
    {
        public void F3(T s1)
        {
            Console.WriteLine("Отправка сообщения:");
            s1.F2();
        }
    }

    interface I3<T>
    {
        T O1 { get; }
    }
    class C2<T> : I3<T>
    {
        public T O1 { get; }
        public C2(T o1) => this.O1 = o1;
    }
}