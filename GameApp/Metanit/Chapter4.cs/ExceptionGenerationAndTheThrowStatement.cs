using System;

namespace ExceptionGenerationAndTheThrowStatement
{
    class Exeption1
    {
        static void MainExeption1(string[] args)
        {
            try
            {
                Console.Write("Введите строку: ");
                string message = Console.ReadLine();
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            Console.Read();
        }
    }
    class Exeption2
    {
        static void MainExeption2(string[] args)
        {
            try
            {
                Console.Write("Введите номер: ");
                string mes = Console.ReadLine();
                if (mes.Length < 10)
                {
                    throw new Exception("Номер меньше 10-ти символов");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}