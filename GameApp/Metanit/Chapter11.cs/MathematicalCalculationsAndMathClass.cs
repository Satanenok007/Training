using System;

namespace MathematicalCalculationsAndMathClass
{
    class C1
    {
        static void F1()
        {
            double obj1 = Math.Abs(-20.99);
            double obj2 = Math.Acos(4);
            double obj3 = Math.BigMul(1000, 2560);
            double obj4 = Math.Ceiling(11.43);

            int res1;
            int obj5 = Math.DivRem(19, 4, out res1);

            double obj6 = Math.Floor(9.12);
            double obj7 = Math.IEEERemainder(54, 9);

            double obj8 = Math.Round(76.45);
            double obj9 = Math.Round(45.20);

            double obj10 = Math.Round(10.233, 3);
            double obj11 = Math.Round(33.749, 2);

            int obj12 = Math.Sign(19);
            int obj13 = Math.Sign(-8);

            double obj14 = Math.Sqrt(225);

            double obj15 = Math.Truncate(26.18);

            double radius = 50;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга с радиусом {radius} равна {Math.Round(area, 2)}");
        }
    }
}