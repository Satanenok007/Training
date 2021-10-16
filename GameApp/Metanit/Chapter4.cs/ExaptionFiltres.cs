using System;
namespace ExaptionFiltres
{
    class Program
    {
        static void MainExaptionFiltres(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение: {ex.Message}");
            }

            int i = 1;
            int j = 0;
            try
            {
                int result = i / j;
            }
            catch (DivideByZeroException) when (i == 0 && j == 0)
            {
                Console.WriteLine("j не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}