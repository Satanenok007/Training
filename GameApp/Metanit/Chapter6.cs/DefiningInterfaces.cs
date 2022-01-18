using System;

namespace DefiningInterfaces
{
    class C1
    {
        static void F1(string[] args)
        {
            Console.WriteLine(Intf1.F2);
            Intf1.F2 = 100;
            Console.WriteLine(Intf1.F2);
            double division = Intf1.Division(100, 10);
            Console.WriteLine(division);
        }
    }

    public interface Intf1
    {
        public const int n1 = 0;
        public static int n2 = 60;
        static int F2
        {
            get { return n2; }
            set
            {
                if (value > 0) n2 = value;
            }
        }
        static double Division(double numb1, double numb2) => numb1 / numb2;
    }
}