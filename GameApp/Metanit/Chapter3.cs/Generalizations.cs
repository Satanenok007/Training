using System;

namespace Generalizations
{
    class C1
    {
        static void F1()
        {
            C2<int> obj1 = new C2<int> { n2 = 100 };
            C2<string> obj2 = new C2<string> { n2 = 123 };

            obj1.n1 = 10;
            obj2.n1 = "45";

            int res1 = obj1.n1;
            string res2 = obj2.n1;

            Console.WriteLine(res1);
            Console.WriteLine(res2);


            C2<int> obj3 = new C2<int> { n2 = 23 };
            C2<int>.n3 = 145;

            C2<string> obj4 = new C2<string> { n2 = 97 };
            C2<string>.n3 = "178";

            Console.WriteLine(C2<int>.n3);
            Console.WriteLine(C2<string>.n3);


            int x1 = 10;
            int y1 = 20;
            F2<int>(ref x1, ref y1);
            Console.WriteLine($"x1: {x1}, y1: {y1}");

            string x2 = "hello";
            string y2 = "bye";
            F2<string>(ref x2, ref y2);
            Console.WriteLine($"x2: {x2}, y2: {y2}");
        }

        public static void F2<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    class C2<T>
    {
        public T n1 { get; set; }
        public int n2 { get; set; }
        public static T n3;
    }
}