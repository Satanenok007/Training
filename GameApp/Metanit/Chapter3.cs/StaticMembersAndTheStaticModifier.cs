using System;

namespace StaticMembersAndTheStaticModifier
{
    class C1
    {
        static void F1(string[] args)
        {
            Console.WriteLine(C2.n1);
            C2.n1 = +10;

            Console.WriteLine(C3.n2);
            C3.n2 += 10;
            Console.WriteLine(C3.n2);
        }
    }

    class C2
    {
        public static int n1 = 10;
        public static int s1;
        static C2()
        {
            Console.WriteLine("www");
        }
        public C2(int r1)
        {
            s1 = r1 + n1;
        }

        public static int GetInfo(int r1)
        {
            r1 = s1 + n1;
            return r1;
        }
    }

    class C3
    {
        public static int n2 = 34;
        public static int s2;
        static C3()
        {
            Console.WriteLine("Hello");
        }
        public C3(int r2)
        {
            s2 = r2 + n2;
        }

        public static int GetInfo(int r2)
        {
            r2 = s2 - n2;
            return r2;
        }
    }
}