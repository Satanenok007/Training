using System;

namespace typesOfExceptions
{
    class Program
    {
        static void typeExceptions(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
        }


        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0;  // DivideByZeroException
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }

        static void Mains(string[] args)
        {
            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }


        class ExceptionTestClass
        {
            public static void Main()
            {
                int x = 0;
                try
                {
                    int y = 100 / x;
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine($"ArithmeticException Handler: {e}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Generic Exception Handler: {e}");
                }
            }
        }
    }
}