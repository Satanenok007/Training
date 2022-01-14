using System;

namespace CovarianceAndContravarianceOfDelegates
{
    class C1
    {
        delegate C2 c2(string s1);
        delegate T c2<out T>(string s1);
        delegate void c3(C3 s2);
        delegate void c3<in T>(T s2);
        static void F1(string[] args)
        {
            c2 obj1 = F2;
            C2 obj2 = obj1("aaaa");
            obj2.F2();
            C3 F2(string text) => new C3(text);

            c2<C2> obj3 = F2;
            C2 obj4 = obj1("bbbbb");
            obj2.F2();


            c3 obj5 = F3;
            obj5(new C3("cccc"));
            void F3(C2 message) => message.F2();

            c3<C3> obj6 = F3;
            obj6(new C3("ddddddddd"));
        }
    }
    class C2
    {
        public string s1 { get; }
        public C2(string _s1) => s1 = _s1;
        public virtual void F2() => Console.WriteLine($"Message: {s1}");
    }
    class C3 : C2
    {
        public C3(string s1) : base(s1) { }
        public override void F2() => Console.WriteLine($"Email: {s1}");
    }
    class C4 : C2
    {
        public C4(string s1) : base(s1) { }
        public override void F2() => Console.WriteLine($"Sms: {s1}");
    }
}