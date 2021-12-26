using System;

namespace ExceptionHandling
{
    class C1
    {
        static void F1()
        {
            int obj1;
            string temp = Console.ReadLine();
            if (Int32.TryParse(temp, out obj1))
            {
                obj1 += obj1;
                Console.WriteLine("sum: " + obj1);
            }
            else
            {
                Console.WriteLine("error");
            }

            try
            {
                int n2 = 5;
                int n3 = n2 / 0;
                Console.WriteLine($"try: {n2}");
            }
            catch
            {
                Console.WriteLine("catch");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            if (Int32.TryParse(temp, out obj1))
            {
                obj1 -= obj1;
                Console.WriteLine("difference: " + obj1);
            }
            else
            {
                Console.WriteLine("error");
            }

            try
            {
                int obj2 = 100;
                int obj3 = obj2 / 0;
                Console.WriteLine($"Try: {obj2}");
            }
            catch
            {
                Console.WriteLine("Catch");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}