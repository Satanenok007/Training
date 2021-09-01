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
            static void Main(string[] args)
            {
                User user = new User();
                string companyName = user?.Phone?.Company?.Name ?? "не установлено";
                Console.WriteLine(companyName);
            }
        }
    }
}