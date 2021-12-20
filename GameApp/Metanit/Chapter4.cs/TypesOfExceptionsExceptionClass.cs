using System;

namespace TypesOfExceptionsExceptionClass
{
    class C1
    {
        static void F1()
        {
            try
            {
                object obj1 = 10;
                int n1 = (int)obj1;
                Console.WriteLine($"n1: {n1}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}