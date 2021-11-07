using System;
namespace AbstractClassesAndClassMembers
{
    abstract class C1
    {
        public string S1 { get; set; }
        public abstract string n1 { get; set; }
        public C1(string s1)
        {
            S1 = s1;
        }
        public abstract void Info();
    }
    class C2 : C1
    {
        public int S2 { get; set; }
        public C2(string s1, int s2)
         : base(s1)
        {
            S2 = s2;
        }

        public override string n1
        {
            get { return "n1" + n1; }
            set { n1 = value; }
        }
        public override void Info()
        {
            Console.WriteLine($"{S1} = {S2}");
        }
    }

    class C3
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2("s1", 123);
            obj1.Info();

            C1 obj2 = new C2("s1", 1234);
            obj2.Info();
        }
    }
}
