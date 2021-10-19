using System;

namespace ConditionalConstructions
{
    class ConditionalConstructions
    {
        static void F10()
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine($"{num1} > {num2}, но < {num3}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} < {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} == {num2}");
            }

            Console.WriteLine("Нажмите 1 или 2");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "2":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную кнопку");
                    break;
            }

            int x = 18;
            int y = 31;
            Console.WriteLine("Нажмите + или -");
            string keys = Console.ReadLine();

            int result1 = keys == "+" ? (x + y) : (x - y);
            int result2 = keys == "-" ? (x + y) : (x - y);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }
    }
}