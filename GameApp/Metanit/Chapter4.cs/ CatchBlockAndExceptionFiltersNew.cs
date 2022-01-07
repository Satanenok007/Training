using System;

namespace CatchBlockAndExceptionFilters
{
    class C1
    {
        static void F1(string[] args)
        {
            int obj1 = 1;
            int obj2 = 0;

            try
            {
                int obj3 = 14;
                int obj4 = obj3 / 0;
                Console.WriteLine($"obj4: {obj4}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение DivideByZeroException");
            }


            try
            {
                int res = obj1 / obj2;
            }
            catch (DivideByZeroException) when (obj2 == 0 && obj1 == 0)
            {
                Console.WriteLine("obj2 = 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}