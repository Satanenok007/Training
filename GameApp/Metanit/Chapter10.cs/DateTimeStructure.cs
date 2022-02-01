using System;
namespace DateTimeStructure
{
    class C1
    {
        static void F1()
        {
            DateTime obj1 = new DateTime();
            Console.WriteLine(obj1);

            DateTime obj2 = new DateTime(2011, 7, 27);
            Console.WriteLine(obj2);

            DateTime obj3 = new DateTime(2018, 1, 1, 1, 29, 11);
            Console.WriteLine(obj3);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);

            DateTime obj4 = new DateTime(1582, 10, 5);
            Console.WriteLine(obj4.DayOfWeek);

            DateTime obj5 = new DateTime(2002, 10, 1, 11, 21, 9);
            DateTime obj6 = new DateTime(2004, 7, 27, 10, 26, 3);
            Console.WriteLine(obj5.Subtract(obj6));

            DateTime obj7 = new DateTime(2003, 3, 24, 22, 15, 12);
            Console.WriteLine(obj7.AddHours(-3));

            DateTime obj8 = new DateTime(2007, 12, 9, 9, 9, 9);
            Console.WriteLine(obj8.ToLocalTime());
            Console.WriteLine(obj8.ToUniversalTime());
            Console.WriteLine(obj8.ToLongDateString());
            Console.WriteLine(obj8.ToShortDateString());
            Console.WriteLine(obj8.ToLongTimeString());
            Console.WriteLine(obj8.ToShortTimeString());
        }
    }
}