using System;

namespace ExceptionGenerationAndThrowStatement
{
    class C1
    {
        static void F1()
        {
            try
            {
                try
                {
                    Console.Write("Введите строку: ");
                    string message = Console.ReadLine();
                    if (message.Length > 10)
                    {
                        throw new Exception("Длина строки > 10 символов");
                    }
                }
                catch
                {
                    Console.WriteLine("Исключение");
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