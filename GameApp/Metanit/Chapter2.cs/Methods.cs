using System;

namespace Methods
{
    class Methods
    {
        static void F15(string[] args)
        {
            EveningMessage();
            MorningMessage();
        }
        static void MorningMessage()
        {
            Console.WriteLine("Good morning :)");
        }
        static void EveningMessage()
        {
            Console.WriteLine("Good evening :)");
        }

        static int Sum()
        {
            int n1 = 10;
            int n2 = 13;
            int n3 = n1 + n2;
            return n3;
        }

        static void SayGoodMorning()
        {
            int hour = 12;
            if (hour > 11)
            {
                return;
            }
            else
            {
                Console.WriteLine("Good Morning");
            }
        }
    }
}