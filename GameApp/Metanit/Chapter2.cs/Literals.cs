using System;

namespace Literals
{
    class Literals
    {
        class LogicalLiterals
        {
            static void F3()
            {
                int x = 10;
                bool result;
                if (x == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                Console.WriteLine(result);


                int i = 1;
                Console.WriteLine(i);
                Console.WriteLine(x);

                Console.WriteLine("Компания \"RedStrim\"");
                Console.WriteLine("Введите имя: \nстрока для ввода:");
            }
        }
    }
}