using System;

namespace OperatorOverloadings
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2 { n1 = 23 };
            C2 obj2 = new C2 { n1 = 45 };
            bool result = obj1 > obj2;
            Console.WriteLine(result);

            C2 obj3 = obj1 + obj2;
            Console.WriteLine(obj3.n1);

            C3 obj4 = new C3() { n2 = 2 };
            if (!obj4)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }

    class C2
    {
        public int n1 { get; set; }

        public static C2 operator +(C2 x, C2 y)
        {
            return new C2 { n1 = x.n1 + y.n1 };
        }
        public static bool operator >(C2 x, C2 y)
        {
            return x.n1 > y.n1;
        }
        public static bool operator <(C2 x, C2 y)
        {
            return x.n1 < y.n1;
        }

        public static C2 operator ++(C2 counter1)
        {
            return new C2 { n1 = counter1.n1 + 10 };
        }
    }


    class C3
    {
        public int n2 { get; set; }

        public static bool operator !(C3 x)
        {
            return x.n2 == 0;
        }

        public static bool operator true(C3 y)
        {
            return y.n2 != 0;
        }
        public static bool operator false(C3 z)
        {
            return z.n2 == 0;
        }
    }
}