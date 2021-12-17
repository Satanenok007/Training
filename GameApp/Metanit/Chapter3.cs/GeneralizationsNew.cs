using System;

namespace Generalizations
{
    class C1
    {
        static void F1()
        {
            C2<int> ob1 = new C2<int> { obj2 = 1 };
            C2<string> ob2 = new C2<string> { obj2 = 2 };

            ob1.obj1 = 10;
            ob2.obj1 = "21";

            int result1 = ob1.obj1;
            string result2 = ob2.obj1;

            Console.WriteLine(result1);
            Console.WriteLine(result2);


            C2<int> ob3 = new C2<int> { obj2 = 50 };
            C2<int>.obj3 = 150;
            Console.WriteLine(C2<int>.obj3);
            Console.WriteLine(C2<string>.obj3);

            C2<string> ob4 = new C2<string> { obj2 = 40 };
            C2<string>.obj3 = "12345";
            Console.WriteLine(C2<int>.obj3);
            Console.WriteLine(C2<string>.obj3);


            int a = 100;
            int b = 200;
            F2<int>(ref a, ref b);
            Console.WriteLine($"{a}, {b}");

            string c = "www";
            string d = "ccc";
            F2<string>(ref c, ref d);
            Console.WriteLine($"{c}, {d}");
        }

        public static void F2<T>(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }
    }

    class C2<T>
    {
        public T obj1 { get; set; }
        public int obj2 { get; set; }
        public static T obj3;
    }
}