using System;

namespace TheDifferenceBetweenOverridingAndHidingMethods
{
    class C1
    {
        public string S1 { get; set; }
        public C1(string s1)
        {
            S1 = s1;
        }
        public virtual void Info()
        {
            Console.WriteLine(S1);
        }
    }
    class C2 : C1
    {
        public string S2 { get; set; }
        public C2(string S1, string s2)
            : base(S1)
        {
            S2 = s2;
        }

        public override void Info()
        {
            Console.WriteLine($"{S1} = {S2}");
        }
    }


    class C3
    {
        public string S3 { get; set; }
        public C3(string s3)
        {
            S3 = s3;
        }

        public void Display()
        {
            Console.WriteLine(S3);
        }
    }

    class C4 : C3
    {
        public string S4 { get; set; }
        public C4(string S3, string s4)
                : base(S3)
        {
            S4 = s4;
        }
        public new void Display()
        {
            Console.WriteLine($"{S3} работает в {S4}");
        }
    }

    class Program
    {
        static void F1(string[] args)
        {
            C1 s1 = new C2("s1", "s2");
            s1.Info();

            C3 s2 = new C4("s3", "s4");
            s2.Display();
        }
    }
}