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
}