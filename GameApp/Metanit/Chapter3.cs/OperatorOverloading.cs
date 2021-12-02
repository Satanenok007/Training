using System;

namespace OperatorOverloading
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 cl1 = new C2 { res = 10 };
            C2 cl2 = new C2 { res = 11 };
            bool resut = cl1 > cl2;
            Console.WriteLine(resut);

            C2 cl3 = cl1 + cl2;
            Console.WriteLine(cl3.res);
        }
    }

    class C2
    {
        public int res { get; set; }
        public static C2 operator +(C2 n1, C2 n2)
        {
            return new C2 { res = n1.res + n2.res };
        }
        public static C2 operator -(C2 n1, C2 n2)
        {
            return new C2 { res = n1.res - n2.res };
        }
        public static bool operator <(C2 n1, C2 n2)
        {
            return n1.res < n2.res;
        }
        public static bool operator >(C2 n1, C2 n2)
        {
            return n1.res > n2.res;
        }
    }
}