using System;
namespace ExaptionFiltres
{
    class C1
    {
        static void F1(string[] args)
        {
            try
            {
                int n1 = 10;
                int n2 = n1 / 0;
                Console.WriteLine($"Результат: {n2}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение: {ex.Message}");
            }

            int n3 = 5;
            int n4 = 0;
            try
            {
                int result = n3 / n4;
            }
            catch (DivideByZeroException) when (n3 == 0 && n4 == 0)
            {
                Console.WriteLine("n4 не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}