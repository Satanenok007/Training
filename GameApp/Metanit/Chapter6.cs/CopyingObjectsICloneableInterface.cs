using System;

namespace CopyingObjectsICloneableInterface
{
    class C1
    {
        static void F1()
        {
            var obj1 = new C2("obj1", 1);
            var obj2 = obj1;
            obj2.S1 = "obj2";
            Console.WriteLine(obj1.S1);

            var obj3 = new C3("obj3", 3, new C4("s5"));
        }
    }

    class C2
    {
        public string S1 { get; set; }
        public int S2 { get; set; }
        public C2(string s1, int s2)
        {
            S1 = s1;
            S2 = s2;
        }
    }

    class C3 : I1
    {
        public string S3 { get; set; }
        public int S4 { get; set; }
        public C4 S5 { get; set; }
        public C3(string s3, int s4, C4 s5)
        {
            S3 = s3;
            S4 = s4;
            S5 = s5;
        }
        public object F2() => MemberwiseClone();
    }
    class C4
    {
        public string S6 { get; set; }
        public C4(string s6) => S6 = s6;
    }

    public interface I1
    {
        object F2();
    }
}