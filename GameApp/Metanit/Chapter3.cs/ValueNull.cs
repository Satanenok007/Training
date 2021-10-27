using System;

namespace ValueNull
{
    class Program
    {
        static object x = null;
        object y = x ?? 100;

        static object z = 200;
        object t = z ?? 44;
    }

    class ConditionOperatorNull
    {
        class User
        {
            public Phone Phone { get; set; }
        }

        class Phone
        {
            public Company Company { get; set; }
        }

        class Company
        {
            public string Name { get; set; }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                User user = new User();
                string companyName = user?.Phone?.Company?.Name ?? "не установлено";
                Console.WriteLine(companyName);
            }
        }
    }

    class Example2
    {
        static void Main2(string[] args)
        {
            int? x;
            int? y;

            x = null;
            y = x ?? 50;
            Console.WriteLine("y = {0}", y);
            x = 20;
            y = x ?? 50;
            Console.WriteLine("y = {0}", y);
        }
    }

    class Registration
    {
        class C1
        {
            public C2 c2 { get; set; }
        }

        class C2
        {
            public C3 c3 { get; set; }
        }

        class C3
        {
            public string name { get; set; }
        }

        class Program
        {
            static void F1(string[] args)
            {
                C1 user = new C1();
                string nameUser = user?.c2?.c3?.name ?? "не указано";
                Console.WriteLine(nameUser);

                int? n1;
                int? n2;

                n1 = null;
                n2 = n1 ?? 12;
                Console.WriteLine("n2 = {0}", n2);
                n1 = 30;
                n2 = n1 ?? 100;
                Console.WriteLine("n2 = {0}", n2);
            }
        }
    }
}