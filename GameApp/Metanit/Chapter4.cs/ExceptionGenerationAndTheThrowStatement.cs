using System;

namespace ExceptionGenerationAndTheThrowStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}