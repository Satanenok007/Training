using System;

namespace HidingMethodsAndProperties
{
    class Program
    {
        static void F1()
        {
            A obj1 = new A("aaa");
            obj1.F2();

            B obj2 = new B("aaa", "bbb");
            obj2.F2();
        }
    }
    class A
    {
        public string s1 { get; set; }
        public A(string s1)
        {
            this.s1 = s1;
        }
        public void F2()
        {
            Console.WriteLine($"s1: {s1}");
        }
    }
    class B : A
    {
        public string s2 { get; set; }
        public B(string s1, string s2)
        : base(s1)
        {
            this.s2 = s2;
        }
        public new void F2()
        {
            Console.WriteLine($"s1: {s1} s2: {s2}");
        }
    }
}