using System;

namespace ProgramStructure
{
    class P1
    {
        static void F1(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
        }
    }
}