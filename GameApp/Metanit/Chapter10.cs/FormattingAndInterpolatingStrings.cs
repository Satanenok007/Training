using System;

namespace FormattingAndInterpolatingStrings
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void FormattingAndInterpolatingStrings(string[] args)
        {
            Person p1 = new Person { Name = "Rubbi", Age = 23 };

            Console.WriteLine("Имя: {0}  Возраст: {1}", p1.Name, p1.Age);

            string output = String.Format("Имя: {0}  Возраст: {1}", p1.Name, p1.Age);
            Console.WriteLine(output);
        }
    }

    class CurrencyFormatting
    {
        static void CurrencyFormattings()
        {
            double numb1 = 13.5;
            string result1 = String.Format("{0:C}", numb1);
            Console.WriteLine(result1);
            string result2 = String.Format("{0:C2}", numb1);
            Console.WriteLine(result2);
        }
    }

    class FormattingIntegers
    {
        static void FormattingInteger()
        {
            int numb = 78;
            string res1 = String.Format("{0:d}", numb);
            Console.WriteLine(res1);
            string res2 = String.Format("{0:d4}", numb);
            Console.WriteLine(res2);
        }
    }

    class FormattingFractionalNumbers
    {
        static void FormattingFractionalNumber()
        {
            int number = 30;
            string result = String.Format("{0:f}", number);
            Console.WriteLine(result);

            double number2 = 19.09;
            string result2 = String.Format("{0:f4}", number2);
            Console.WriteLine(result2);

            double number3 = 45.8;
            string result3 = String.Format("{0:f1}", number3);
            Console.WriteLine(result2);
        }
    }

    class PercentageFormat
    {
        static void PercentageFormats()
        {
            decimal percentages = 0.45324m;
            Console.WriteLine("{0:P1}", percentages);
        }
    }

    class CustomizableFormats
    {
        static void CustomizableFormat()
        {
            long number = 375256853991;
            string result = String.Format("{0:+### (###) ###-##-##}", number);
            Console.WriteLine(result);
        }
    }

    class MethodToString
    {
        static void MethodsToString()
        {
            long phoneNumber = 375256853991;
            Console.WriteLine(phoneNumber.ToString("+### (###) ###-##-##"));

            double money = 45.9;
            Console.WriteLine(money.ToString("C2"));
        }
    }

    class StringInterpolation
    {
        static void StringInterpolations()
        {
            Person person1 = new Person { Name = "Jasica", Age = 31 };

            Console.WriteLine($"Имя: {person1.Name}  Возраст: {person1.Age}");


            int x = 10;
            int y = 800;
            string result = $"{x} + {y} = {x + y}";
            Console.WriteLine(result);

            person1 = null;
            string output = $"{person1?.Name ?? "Имя по умолчанию"}";
            Console.WriteLine(output);

            long number = 375256853991;
            Console.WriteLine($"{number:+### ### ### ## ##}"); // +1 987 654 32 10

            Console.WriteLine($"Имя: {person1.Name,-5} Возраст: {person1.Age}");
            Console.WriteLine($"Имя: {person1.Name,5} Возраст: {person1.Age}");
        }
    }
}