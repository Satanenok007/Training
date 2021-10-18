using System;

namespace ConsoleInputOutput
{
    class Program
    {
        static void F5(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите номер телефона: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер заказа: ");
            int orderNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите почту: ");
            double email = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Имя: {name} Номер телефона: {number}  Номер заказа: {orderNumber}  Почта: {email}");
        }
    }
}