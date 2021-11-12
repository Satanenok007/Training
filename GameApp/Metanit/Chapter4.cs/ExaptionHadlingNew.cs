using System;

namespace ExaptionHadling
{
    class C1
    {
        static void F1(string[] args)
        {
            try
            {
                int n1 = 5;
                int n2 = n1 / 0;
                Console.WriteLine($"Результат: {n2}");
            }
            catch
            {
                Console.WriteLine("исключение");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Конец программы");
        }
    }

    class C2
    {
        static void F2(string[] args)
        {
            Console.WriteLine("Число: ");
            int n1;
            string res = Console.ReadLine();

            if (Int32.TryParse(res, out n1))
            {
                n1 += n1;
                Console.WriteLine("Cумма чисел: " + n1);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}