using System;

namespace HelloApp
{
    public static class Program
    {
        public static void Main()
        {
            // Console.Write("Введите свое имя: ");
            // string myName = Console.ReadLine();
            // Console.WriteLine($"Привет {myName}");


            // string name = "Nastya";
            // Console.WriteLine(name);

            // name = "Kate";
            // Console.WriteLine(name);
            // Console.Read();

            // //Литералы
            // Console.WriteLine(true); //Логические
            // Console.WriteLine(false);

            // Console.WriteLine(-5);//Целочисловые
            // Console.WriteLine(0b11);//двоичная сис-ма
            // Console.WriteLine(0xFF);//шеснадцатеричная сис-ма
            // Console.WriteLine(3.2e3);//вещественные
            // Console.WriteLine('\x78');//символьные
            // Console.WriteLine("hello");//строковые
            // Console.WriteLine("Привет \nмир");// /n перенос на след. строку

            // //Консольнный ввод
            // string Name = "Nastya";
            // int age = 16;
            // double height = 1.7;
            // Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
            // // Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age); второй способ вывода
            // Console.ReadKey();

            // //Арефметические операции
            // int x = 20;
            // int addition = x + 10;
            // int subtraction = x - 4;
            // int division = x / 2;
            // int multiplication = x * 6;
            // int theRemainderOfTheDivision = x % 2;

            // //Операции присваивания
            // int x = 10;
            // x += 10;
            // x -= 4;
            // x *= 2;
            // x /= 8;
            // x <<= 4;
            // x >>= 2;

            // //Условные выражения
            // int x = 13;
            // int y = 5;
            // bool z = x == y; // false

            // int x = 55;
            // int y = 3;
            // bool z = x != y;    // true
            // bool d = x != 10;     // false

            // int x = 25;
            // int y = 20;
            // bool z = x < y; // false

            // int x = 64;
            // int y = 45;
            // bool z = x > y;     // true
            // bool d = x > 80;    // false

            // int a = 15;
            // int b = 7;
            // bool z = x <= y;     // false
            // bool d = x <= 20;    // true

            // int a = 18;
            // int b = 6;
            // bool z = x >= y;     // true
            // bool d = x >= 27;    // false

            // bool x = (4 > 8) | (1 < 20); // 4 > 8 - false, 1 < 20 - true, возвращается true
            // bool y = (0 > 23) | (9 > 40); // 0 > 23 - false, 9 > 40 - false, возвращается false

            // bool x = (1 > 5) & (1 < 6); // 1 > 5 - false, 1 < 6 - true, возвращается false
            // bool y = (3 < 8) & (5 < 15); // 3 < 8 - true, 5 < 15 - true, возвращается true

            // bool x = (7 > 10) || (2 < 13); // 7 > 10 - false, 2 < 13 - true, возвращается true
            // bool y = (6 > 14) || (8 > 17); // 6 > 14 - false, 8 > 17 - false, возвращается false

            // bool x = (16 > 20) && (6 < 1); // 16 > 20 - false, 6 < 1 - true, возвращается false
            // bool y = (9 < 70) && (10 < 100); // 9 < 70 - true, 10 < 100 - true, возвращается true

            // bool x = true;
            // bool y = !x;    // false

            // bool x = (4 > 16) ^ (2 < 10); // 4 > 16 - false, 2 < 10 - true, возвращается true
            // bool y = (50 > 29) ^ (10 / 2 < 7); // 50 > 29 - true, 10/2 < 7 - true, возвращается false

            // //Циклы
            // int j = 10;
            // do
            // {
            //     Console.WriteLine(j); //отличается от while тем, что сначала делает, потом проверяет условие и выполнится в любом случае
            //     j--;
            // }
            // while (j > 5);


            //Ключевое слово params

            // static void Params(params int[] array)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         Console.Write(array[i] + " ");
            //     }
            //     Console.WriteLine();

            // }
            // Params(1,2,3,4,5,6);


            //Условная конструкция switch
            // int number = 10;
            // static void Switch(int number)
            // {
            //     switch (number)
            //     {
            //         case 1: 
            //         Console.Write("10");
            //         break;
            //         case 2:
            //         Console.Write("20");
            //         break;
            //         default:
            //         Console.Write("число больше 10-ти");
            //         break;
            //     }
            // }
            // Switch(number);


            //Тернарный оператор
            // Random rnd = new Random();
            // int number = rnd.Next(0, 4);
            // bool result;
            // result = number == 3 ? true : false;
            // Console.Write(result);
            // Console.WriteLine();


            //Передача параметров по ссылке.Выходные параметры

            // int x = 10;
            // int y = 15;
            // int temp;
            // Addition(ref x, y);
            // Console.WriteLine(x);

            // static void Addition(ref int x, int y)
            // {
            //     x += y;
            // }

            // static void Sum(int x, int y, out int a)
            // {
            //     a = x + y;
            // }
            // Sum(10, 45, out temp);


            //Сокращение методов
            // static int Y1(int x)
            // {
            //     return x * x - 2 / x;
            // }
            // Y1(20);

            // static int Y2(int x) => x * x - 2 / x;
            // Y2(20);


            //Кортежи
            // var tuple1 = Method();
            // Console.WriteLine(tuple1.Item1);
            // Console.WriteLine(tuple1.Item2);
            // static (int, int) Method()
            // {
            //     var res = (5, 10);
            //     return res;
            // }


            // //Рекурсивные функции
            // static int TheAreaOfTheTriangle(int x, int y)
            // {
            //     if ((x == 1) && (y == 1))
            //     {
            //         return 1;
            //     }
            //     else if (x > 1)
            //     {
            //         return TheAreaOfTheTriangle(x - 1, y) + y;
            //     }
            //     else
            //     {
            //         return TheAreaOfTheTriangle(x, y - 1) + 1;
            //     }
            // }
            // int result = TheAreaOfTheTriangle(9, 2);
            // Console.WriteLine(result);


            // static int TheSquareOfTheNumber(int x)
            // {
            //     if (x == 1)
            //     {
            //         return 1;
            //     }
            //     else
            //     {
            //         return TheSquareOfTheNumber(x - 1) + 2 * x - 1;
            //     }
            // }
            // int Result = TheSquareOfTheNumber(9);
            // Console.WriteLine(Result);


            static void Foo(int i)
            {
                Console.WriteLine(i);
                if (i >= 3)
                {
                    return;
                }
                i++;
                Foo(i);
            }
            Foo(0);


            int[] A = { 5, 7, 2, -1 };
            int n = 4;
            int sum;
            sum = Sum(0, A, n);

            static int Sum(int i, int[] A, int n)
            {
                if (i == n - 1)
                {
                    return A[i];
                }
                else
                {
                    return A[i] + Sum(i + 1, A, n);
                }
            }
            Console.WriteLine(sum);

            //enum
            // static void MathOp(double x, double y, Operation op)
            // {
            //     double result = 0.0;

            //     switch (op)
            //     {
            //         case Operation.Add:
            //             result = x + y;
            //             break;
            //         case Operation.Subtract:
            //             result = x - y;
            //             break;
            //         case Operation.Multiply:
            //             result = x * y;
            //             break;
            //         case Operation.Divide:
            //             result = x / y;
            //             break;
            //     }

            //     Console.WriteLine("Результат операции равен {0}", result);
            // }

            // MathOp(10, 5, Operation.Add);
            // MathOp(11, 5, Operation.Multiply);
        }
        // enum Operation
        // {
        //     Add = 1,
        //     Subtract,
        //     Multiply,
        //     Divide
        // }
    }
}


