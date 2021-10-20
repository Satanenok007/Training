using System;

namespace MethodParameters
{
    class MethodParameters
    {
        static void F16()
        {
            int x = 1;
            int y = 2;
            string s1 = "Hello";
            string s2 = "Fedor";
            string s3 = "how are you";
            string result1 = Multiplication(s1, s2, s3);
            int result2 = Division(x, y);
            Console.WriteLine(result2);

            result2 = Division(y, 12);
            Console.WriteLine(result2);

            result2 = Division(x / y / 10, 5);
            Console.WriteLine(result2);
        }
        static int Division(int x, int y)
        {
            return x / y;
        }

        static string Multiplication(string s1, string s2, string s3, string s4 = "Today?")
        {
            return s1 + s2 + s3 + s4;
        } 

    }
}