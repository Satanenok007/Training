using System;

namespace Tuples
{
    class Tuples
    {
        static void F21()
        {
            static Tuple<int, float, string, char> Corteg(int a, string name)
            {
                int sqr = a * a;
                float sqrt = (float)(Math.Sqrt(a));
                string s = "Привет, " + name;
                char ch = (char)(name[0]);

                return Tuple.Create<int, float, string, char>(sqr, sqrt, s, ch);
            }

            static void Tuples(string[] args)
            {
                var myTuple = Corteg(25, "Alexandr");
                Console.WriteLine("{0}\n25 в квадрате: {1}\nКвадратный корень из 25: "
                    + "{2}\nПервый символ в имени: {3}\n", myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);

                var myTuple2 = Tuple.Create<int, char, string, decimal, float, byte, short, Tuple<int,
                    float, string, char>>(12, 'C', "Name", 12.3892m, 0.5f, 120, 4501, myTuple);
            }
        }
    }

    class C1
    {
        static void F1(string[] args)
        {
            var n1 = (1, 2);
            Console.WriteLine(n1);

            (int, int, string) n2 = (1, 2, "string");
            Console.WriteLine(n2);

            var n3 = (x1: 1, x2: 2);
            Console.WriteLine(n3.x1);
            Console.WriteLine(n3.x2);

            var (x1, x2) = (1, 2);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            var n4 = F2();
            Console.WriteLine(n4.Item1);
            Console.WriteLine(n4.Item2);

            var n5 = F3(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(n5.quantity);
            Console.WriteLine(n5.sumNumber);

        }

        private static (int, int) F2()
        {
            var result = (1, 2);
            return result;
        }

        private static (int sumNumber, int quantity) F3(int[] numbers)
        {
            var result = (sumNumber: 0, quantity: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sumNumber += numbers[i];
                result.quantity++;
            }
            return result;
        }
    }
}