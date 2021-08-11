using System;

// int i;
// float f;
// i = 10;
// f = i; // присвоить целое значение переменной типа float


//Неявное приведение типов(автоматическое)

// namespace ConsoleApplication1
// {
//     class TypeConversion
//     {
//         static void Main(string[] args)
//         {
//             short num1, num2;
//             num1 = 10;
//             num2 = 15;

//             Console.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2));
//         }

//         static int Sum(int x, int y)
//         {
//             return x + y;
//         }
//     }
// }

//Приведение несовместимых типов

// namespace ConsoleApplication
// {
//     class TypeConversion
//     {
//         static void Main(string[] args)
//         {
//             int i1 = 455, i2 = 84500;
//             decimal dec = 7.98845m;

//             // Приводим два числа типа int
//             // к типу short
//             Console.WriteLine((short)i1);
//             Console.WriteLine((short)i2);

//             // Приводим число типа decimal
//             // к типу int
//             Console.WriteLine((int)dec);

//         }
//     }
// }