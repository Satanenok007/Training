using System;

namespace CovarianceAndContravarianceOfGeneralizedInterfaces
{
    class C1
    {
        static void F1(string[] args)
        {
            I1<C3> obj1 = new C5();
            C2 obj2 = obj1.F2("Hello World");
            Console.WriteLine(obj2.S1);


            I1<C3> obj3 = new C5();
            I1<C2> obj4 = obj3;
            C2 obj5 = obj4.F2("Hi!");
            Console.WriteLine(obj5.S1);


            I2<C2> obj6 = new C6();
            obj6.F3(new C2("Hi!"));

            I2<C2> obj7 = new C6();
            I2<C3> obj8 = obj7;
            obj8.F3(new C3("Hello"));
        }
    }

    class C2
    {
        public string S1 { get; set; }
        public C2(string s1) => S1 = s1;
    }
    class C3 : C2
    {
        public C3(string s1) : base(s1) { }
    }

    interface I1<out T>
    {
        T F2(string s1);
    }
    class C5 : I1<C3>
    {
        public C3 F2(string s1)
        {
            return new C3($"s1 : {s1}");
        }
    }

    interface I2<in T>
    {
        void F3(T s1);
    }
    class C6 : I2<C2>
    {
        public void F3(C2 s1)
        {
            Console.WriteLine($"s1.S1 : {s1.S1}");
        }
    }
}