using System;

namespace TheDifferenceBetweenOverridingAndHidingMethods
{
    class C1
    {
        static void F1()
        {
            C2 obj1 = new C3("1", "2");
            obj1.F2();

            C4 obj2 = new C5("3", "4");
            obj2.F3();
        }
    }

    class C2
    {
        public string s1 { get; set; }
        public C2(string s1)
        {
            this.s1 = s1;
        }
        public virtual void F2()
        {
            Console.WriteLine(s1);
        }
    }
    class C3 : C2
    {
        public string s2 { get; set; }
        public C3(string s1, string s2)
        : base(s1)
        {
            this.s2 = s2;
        }

        public override void F2()
        {
            Console.WriteLine($"{s1}, {s2}");
        }
    }

    class C4
    {
        public string s3 { get; set; }
        public C4(string s3)
        {
            this.s3 = s3;
        }

        public void F3()
        {
            Console.WriteLine(s3);
        }
    }

    class C5 : C4
    {
        public string s4 { get; set; }
        public C5(string s3, string s4)
        : base(s3)
        {
            this.s4 = s4;
        }
        public new void F3()
        {
            Console.WriteLine($"{s3}, {s4}");
        }
    }
}