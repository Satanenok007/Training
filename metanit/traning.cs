using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] name)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();


            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");


            string name = "Nastya";
            Console.WriteLine(name);

            name = "Kate";
            Console.WriteLine(name);
            Console.Read();

            //Литералы
            Console.WriteLine(true); //Логические
            Console.WriteLine(false);

            Console.WriteLine(-5);//Целочисловые
            Console.WriteLine(0b11);//двоичная сис-ма
            Console.WriteLine(0xFF);//шеснадцатеричная сис-ма
            Console.WriteLine(3.2e3);//вещественные
            Console.WriteLine('\x78');//символьные
            Console.WriteLine("hello");//строковые
            Console.WriteLine("Привет \nмир");// /n перенос на след. строку

            //Консольнный ввод
            string Name = "Nastya";
            int age = 16;
            double height = 1.7;
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
            // Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age); второй способ вывода
            Console.ReadKey();

            //Арефметические операции
            int x = 20;
            int addition = x + 10;
            int subtraction = x - 4;
            int division = x / 2;
            int multiplication = x * 6;
            int theRemainderOfTheDivision = x % 2;
        }
    }
}

