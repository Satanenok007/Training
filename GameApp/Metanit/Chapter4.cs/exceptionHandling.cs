using System;

namespace ExeptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
        }


        static void TheSquareOfTheNumber(string[] args)
        {
            Console.WriteLine("Введите число");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}