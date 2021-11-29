using System;

namespace ClassAndObject
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2();

            int number1 = obj1.numb1;
            int number2 = obj1.numb2;
            Console.WriteLine($"numb1: {number1}, numb2: {number2}");

            obj1.numb1 = 11;
            obj1.numb2 = 19;
            obj1.GetInfo();
        }
    }
    class C2
    {
        public int numb1 = 10;
        public int numb2;

        public void GetInfo()
        {
            Console.WriteLine($"numb1: {numb1}, numb2: {numb2}");
        }
    }
}