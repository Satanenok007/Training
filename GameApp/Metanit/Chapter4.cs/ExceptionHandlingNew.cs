using System;

namespace ExceptionHandling
{
    class C1
    {
        static void F1()
        {
            int n1;
            string temp = Console.ReadLine();
            if (Int32.TryParse(temp, out n1))
            {
                n1 -= n1;
                Console.WriteLine("difference: " + n1);
            }
            else
            {
                Console.WriteLine("error");
            }

            try
            {
                int n2 = 11;
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

            if (Int32.TryParse(temp, out n1))
            {
                n1 += n1;
                Console.WriteLine("sum: " + n1);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}