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

            C3 cl4 = new C3 { result = 100 };
            C3 cl5 = new C3 { result = 15 };
            bool res = cl1 > cl2;
            Console.WriteLine(resut);

            C3 cl6 = cl4 + cl5;
            Console.WriteLine(cl6.result);
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

    class C3
    {
        public int result { get; set; }
        public static C3 operator +(C3 obj1, C3 obj2)
        {
            return new C3 { result = obj1.result + obj2.result };
        }
        public static C3 operator -(C3 obj1, C3 obj2)
        {
            return new C3 { result = obj1.result - obj2.result };
        }
        public static bool operator <(C3 obj1, C3 obj2)
        {
            return obj1.result < obj2.result;
        }
        public static bool operator >(C3 obj1, C3 obj2)
        {
            return obj1.result > obj2.result;
        }
    }

    class C4
    {
        public int result { get; set; }
        public static C4 operator ++(C4 obj1)
        {
            return new C4 { result = obj1.result + 1 };
        }
        public static C4 operator --(C4 obj1)
        {
            return new C4 { result = obj1.result - 1 };
        }
        public static bool operator true(C4 obj2)
        {
            return obj2.result != 0;
        }
        public static bool operator false(C4 obj2)
        {
            return obj2.result == 0;
        }
    }
}