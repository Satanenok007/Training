using System;

namespace TypesOfExceptionsExceptionСlass
{
    class Example1
    {
        static void Main(string[] args)
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
    }

    class Example2
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;

                int x = 10;
                int y = x / 0;

                object obj = "you";
                int num = (int)obj;
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}