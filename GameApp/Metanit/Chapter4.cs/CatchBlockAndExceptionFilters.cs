using System;

namespace CatchBlockAndExceptionFilters
{
    class C1
    {
        static void F1(string[] args)
        {
            int n1 = 1;
            int n2 = 0;

            try
            {
                int n3 = 100;
                int n4 = n3 / 0;
                Console.WriteLine($"n2: {n4}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение DivideByZeroException");
            }


            try
            {
                int result = n1 / n2;
            }
            catch (DivideByZeroException) when (n2 == 0 && n1 == 0)
            {
                Console.WriteLine("n2 = 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}