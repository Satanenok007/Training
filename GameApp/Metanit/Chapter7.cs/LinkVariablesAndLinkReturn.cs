using System;

namespace LinkVariablesAndLinkReturn
{
    class LocalVariableReference
    {
        static void Main(string[] args)
        {
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine(x);
            xRef = 125;
            Console.WriteLine(x);
            x = 625;
            Console.WriteLine(xRef);

            int a = 5;
            int b = 8;
            ref int pointer = ref a;
            pointer = 34;
            pointer = ref b;
            pointer = 6;
        }
    }

    class TheLinkAsAResultOfTheFunction
    {
        class Exmple1
        {
            static void Main(string[] args)
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
                ref int numberRef = ref Find(4, numbers);
                numberRef = 9;
                Console.WriteLine(numbers[3]);
            }
            static ref int Find(int number, int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return ref numbers[i];
                    }
                }
                throw new IndexOutOfRangeException("число не найдено");
            }
        }

        class Example2
        {
            static ref int Max(ref int n1, ref int n2)
            {
                if (n1 > n2)
                    return ref n1;
                else
                    return ref n2;
            }
            static void Main(string[] args)
            {
                int a = 5;
                int b = 8;
                ref int pointer = ref Max(ref a, ref b);
                pointer = 34;
                Console.WriteLine($"a: {a}  b: {b}");
            }
        }
    }
}