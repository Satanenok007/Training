using System;
using System.Globalization;

namespace TypeConversionAndTheConvertClass
{
    class C1
    {
        static void F1()
        {
            int obj1 = int.Parse("26");
            double obj2 = double.Parse("10.5");
            decimal obj3 = decimal.Parse("21,05");
            byte obj4 = byte.Parse("4");
            Console.WriteLine($"obj1 = {obj1}  obj2 = {obj2}  obj3 = {obj3}  obj4 = {obj4}");

            Console.WriteLine("Введите строку:");
            string? obj5 = Console.ReadLine();

            bool res = int.TryParse(obj5, out var number);
            if (res == true)
            {
                Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            }
            else
            {
                Console.WriteLine("Преобразование завершилось неудачно");
            }

            int obj6 = Convert.ToInt32("23");
            bool obj7 = true;
            double obj8 = Convert.ToDouble(obj7);
            Console.WriteLine($" obj6 = {obj6}  obj8 = {obj8}");
        }
    }
}