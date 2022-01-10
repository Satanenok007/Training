using System;

namespace AnonymousMethods
{
    class C1
    {
        delegate int Sum(int number);
        static void F1(string[] args)
        {
            Sum del1 = SumOfValues();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Cумма {0} равна: {1}", i, del1(i));
            }
        }

        static Sum SumOfValues()
        {
            int result = 0;

            Sum del = delegate (int number)
            {
                for (int i = 0; i <= number; i++)
                {
                    result += i;
                }
                return result;
            };
            return del;
        }
    }
}