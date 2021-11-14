using System;

namespace TypesOfExceptionsExceptionСlass
{
    class C1
    {
        static void F1(string[] args)
        {
            try
            {
                int n1 = 11;
                int n2 = n1 / 0;
                Console.WriteLine($"Результат: {n2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }

    class C2
    {
        static void F2(string[] args)
        {
            try
            {
                int[] m1 = new int[4];
                m1[7] = 9;

                int n1 = 10;
                int n2 = n1 / 0;

                object obj1 = "123";
                int array1 = (int)obj1;
                Console.WriteLine($"Результат: {array1}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Возникло исключение: DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}