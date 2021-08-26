using System;

namespace ConstantsAndFieldsAndStructuresForReading
{
    class Sum
    {
        public const int x = 10;
        public readonly int Y = 20;

        public Sum(int _y)
        {
            Y = _y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Sum.x + 10;
            Console.WriteLine(sum1);
            Sum sum2 = new Sum(15);
            Console.WriteLine(sum2.Y);
        }
    }
}