using System;

namespace AnonymousTypes
{
    class C1
    {
        static void F1(string[] args)
        {
            var obj1 = new { s1 = "a", n1 = 1 };
            Console.WriteLine(obj1.s1);

            var obj2 = new { s1 = "b", n1 = 2 };
            var obj3 = new { s1 = "c", n1 = 3 };
            var obj4 = new { s1 = "d", n1 = 4, c1 = "d" };

            Console.WriteLine(obj1.GetType().Name);
            Console.WriteLine(obj3.GetType().Name);
            Console.WriteLine(obj4.GetType().Name);

            C2 c2 = new C2("Nastya");
            int obj5 = 34;
            var obj6 = new { c2.s3, obj5 };
            Console.WriteLine(c2.s3);

            var people = new[]
            {
                new {s2="e"},
                new {s2="f"}
            };
            foreach (var p in people)
            {
                Console.WriteLine(p.s2);
            }
        }
    }

    class C2
    {
        public string s3 { get; set; }
        public C2(string s3) => this.s3 = s3;
    }

}