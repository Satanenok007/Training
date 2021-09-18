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

    class Exaple3
    {
        [Serializable]
        public class MyException : ApplicationException
        {
            public MyException() { }
            public MyException(string message) : base(message) { }
            public MyException(string message, Exception ex) : base(message) { }
            protected MyException(System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext contex)
                : base(info, contex) { }
        }

        class Program
        {
            static int MyDel(int x, int y)
            {
                if (y == 0)
                {
                    MyException exc = new MyException("ОШИБКА: деление на 0");
                    exc.HelpLink = "http:\\professorweb.ru";
                    throw exc;
                }
                return x / y;
            }

            static void Main()
            {
                try
                {
                    MyDel(5, 0);
                }
                catch (MyException)
                {
                    Console.WriteLine("Возникла ошибка");
                }
            }
        }
    }
}