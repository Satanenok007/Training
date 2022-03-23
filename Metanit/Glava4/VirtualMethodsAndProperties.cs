using System;
namespace VirtualMethodsAndProperties
{
    class A
    {
        static void F1()
        {
            B obj1 = new B("aaa");
            obj1.F2();

            C obj2 = new C("aaa", "ddd");
            obj2.F2();
        }
    }
    class B
    {
        public string s1 { get; set; }
        public B(string s1)
        {
            this.s1 = s1;
        }
        public virtual void F2()
        {
            Console.WriteLine(s1);
        }
    }

    class C : B
    {
        public string s2 { get; set; }
        public C(string s1, string s2)
            : base(s1)
        {
            this.s2 = s2;
        }
        public override void F2()
        {
            Console.WriteLine($"{s1},  {s2}");
        }
    }
}