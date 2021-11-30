using System;

namespace ValueTypeAndReferenceType
{
    class C
    {
        static void F1()
        {
            S1 str1 = new S1();
            S1 str2 = new S1();
            str1.n1 = 10;
            str1.n2 = 20;
            str2 = str1;
            str2.n2 = 25;
            Console.WriteLine(str1.n2);
            Console.WriteLine(str2.n2);

            C1 cl1 = new C1();
            C1 cl2 = new C1();
            cl1.n1 = 10;
            cl1.n1 = 20;
            cl2 = cl1;
            cl1.n1 = 25;
            Console.WriteLine(cl1.n1);
            Console.WriteLine(cl2.n1);

            // S1 str3 = new S1();
            // S1 str4 = new S1();
            // str3.c1 = new C1();
            // str3.c1.n1 = 10;
            // str4 = str3;                      эта штука должна работать, но инициализация полей экземпляра доступна C# 10;
            // Console.WriteLine(str3.c1.n1);
            // Console.WriteLine(str4.c1.n1);

            C1 cl3 = new C1() { n1 = 100, n2 = 43 };
            F2(cl3);
            Console.WriteLine(cl3.n1);
            Console.WriteLine(cl3.n2);
        }

        static void F2(C1 c1)
        {
            c1.n1 = 10;
            Console.WriteLine(c1.n1);
        }
    }

    struct S1
    {
        public int n1;
        public int n2;
        // public C1 c1 = new();
    }

    class C1
    {
        public int n1;
        public int n2;
    }
}