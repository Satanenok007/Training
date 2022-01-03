using System;

namespace NullAndSignificantTypes
{
    class C1
    {
        static void F1(string[] args)
        {

            int? n1 = null;
            if (n1.HasValue)
            {
                int n2 = (int)n1;
                Console.WriteLine(n2);
            }

            int n3 = 19;
            int? n4 = n3;
            Console.WriteLine(n4);

            int? a = 10;
            int? b = a + 17;
            int c = a.Value + 3;

            void PrintNullable(int? number)
            {
                if (number.HasValue)
                {
                    Console.WriteLine(number.Value);
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("параметр равен null");
                }
            }

            PrintNullable(5);
            PrintNullable(null);
        }
    }
}