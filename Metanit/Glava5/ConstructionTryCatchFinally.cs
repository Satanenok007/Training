using System;

namespace ConstructionTryCatchFinally
{
    class A
    {
        static void Main()
        {
            //исключение DivideByZeroException + when
            int n1 = 0;
            int n2 = 10;
            int n3;
            try
            {
                n3 = n2 / n1;
            }
            catch (DivideByZeroException) when (n1 == 0)
            {
                Console.WriteLine("Error: DivideByZeroException, n1 == 0");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: DivideByZeroException");
            }

            //исключение IndexOutOfRangeException
            int[] m1 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < m1.Length; i++)
            {
                Console.WriteLine(m1[i]);
            }

            try
            {
                Console.WriteLine(m1[7]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: IndexOutOfRangeException");
            }

            //условные конструкции
            Console.WriteLine("Введите число: ");
            int a;
            string numb = Console.ReadLine();
            if (Int32.TryParse(numb, out a))
            {
                a *= a;
                Console.WriteLine("Квадрат числа: " + a);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }

            //генерация исключений
            Console.WriteLine("Введите пароль: ");
            string? p = Console.ReadLine();
            try
            {
                if (p == null || p.Length <= 4)
                {
                    throw new Exception("Ненадёжный пароль");
                }
                else
                {
                    Console.WriteLine("Надёжный пароль");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //классы исключений
            try
            {
                User user1 = new User { Login = "Nastya2004", Age = 2004 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //поиск блока catch
            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }

    class User
    {
        private int age;
        public string Login { get; set; } = "";
        public int Age
        {
            get => age;
            set
            {
                if (value <= 2004)
                {
                    Console.WriteLine("Ты ешё сопля зелёная", value);
                }
            }
        }
    }
}