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

            C3 obj2 = new C3();

            int number3 = obj2.numb3;
            int number4 = obj2.numb4;
            Console.WriteLine($"n3: {number3}, n4: {number4}");

            obj2.numb3 = 1;
            obj2.numb4 = 2;
            obj2.F2();
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

    class C3
    {
        public int numb3 = 19;
        public int numb4;

        public void F2()
        {
            Console.WriteLine($"{numb3}, {numb4}");
        }
    }
}