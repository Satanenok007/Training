using System;

namespace Records
{
    class C1
    {
        static void F1()
        {
            var obj1 = new C2("obj1");
            Console.WriteLine(obj1.S1);

            var obj2 = new C2("obj2");
            var obj3 = new C2("obj3");
            Console.WriteLine(obj2 == obj3);

            var obj4 = new C3("obj4");
            var obj5 = new C3("obj5");
            Console.WriteLine(obj4 == obj5);

            var obj6 = new C4("obj6", 6);
            var obj7 = obj6 with { S3 = "obj7" };
            Console.WriteLine($"{obj7.S3} - {obj7.N1}");

            var obj8 = new C5("obj8", 8);
            Console.WriteLine(obj8);

            var (s5, n2) = obj8;
            Console.WriteLine(n2);
            Console.WriteLine(s5);

            var obj9 = new C6("obj9", 9);
            Console.WriteLine(obj9);
        }
    }

    public record C2
    {
        public string S1 { get; init; }
        public C2(string s1) => S1 = s1;
    }
    public class C3
    {
        public string S2 { get; init; }
        public C3(string s2) => S2 = s2;
    }

    public record C4
    {
        public string S3 { get; init; }
        public int N1 { get; init; }
        public C4(string s3, int n1)
        {
            S3 = s3; N1 = n1;
        }
    }

    public record C5(string s5, int n2);
    public record C6(string s6, int n3);
}