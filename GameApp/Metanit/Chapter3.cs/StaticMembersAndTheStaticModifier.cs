using System;

namespace StaticMembersAndTheStaticModifier
{
    class C1
    {
        static void F1(string[] args)
        {
            Console.WriteLine(C2.n1);
            C2.n1 = +10;
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
}