using System;

namespace FindingTheCatchBlockWhenHandlingExceptions
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivisionByZero.M1();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch в Main : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Main");
            }
            Console.WriteLine("Конец метода Main");
        }
    }
    class DivisionByZero
    {
        public static void M1()
        {
            try
            {
                M2();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catch в M1 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в M1");
            }
            Console.WriteLine("Конец M1");
        }
        static void M2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Блок finally в M2");
            }
            Console.WriteLine("Конец M2");
        }
    }
}