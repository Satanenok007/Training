using System;

namespace TheDifferenceBetweenOverridingAndHidingMethods
{
    class C1
    {
        static void F1()
        {
            C2 cl1 = new C3("c1", "c2");
            cl1.Info();

            C4 tom = new C5("c3", "c4");
            tom.Info();
        }
    }

    class C2
    {
        public string c1 { get; set; }
        public C2(string _c1)
        {
            c1 = _c1;
        }
        public virtual void Info()
        {
            Console.WriteLine(c1);
        }
    }
    class C3 : C2
    {
        public string c2 { get; set; }
        public C3(string c1, string _c2)
        : base(c1)
        {
            c2 = _c2;
        }

        public override void Info()
        {
            Console.WriteLine($"c1: {c1}, c2: {c2}");
        }
    }

    class C4
    {
        public string c3 { get; set; }
        public C4(string _c3)
        {
            c3 = _c3;
        }

        public void Info()
        {
            Console.WriteLine(c3);
        }
    }

    class C5 : C4
    {
        public string c4 { get; set; }
        public C5(string c3, string _c4)
        : base(c3)
        {
            c4 = _c4;
        }
        public new void Info()
        {
            Console.WriteLine($"c3: {c3}, c4: {c4}");
        }
    }
}