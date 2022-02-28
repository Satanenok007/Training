using System;

namespace Enum
{
    class A
    {
        static void F()
        {
            B b1 = new B();
            Color color = Color.Pink;
            if (color == Color.Pink)
            {
                Console.WriteLine("Color: pink");
            }
            else
            {
                Console.WriteLine("Other color");
            }

            Color em1 = Color.Green;
            b1.InfoColor(em1);
            b1.InfoColor(Color.Gray);

            b1.F2(1, 2, Numb.Add);
            b1.F2(100, 43, Numb.Multiply);
            b1.F2(100, 73, Numb.Subtract);
            b1.F2(100, 10, Numb.Divide);

            Color em2 = Color.Yellow;
            Console.WriteLine((int)em2);
            Console.WriteLine((int)Color.Gray);
        }
    }

    class B
    {
        public void InfoColor(Color color)
        {
            switch (color)
            {
                case Color.Blue:
                    Console.WriteLine("color: blue");
                    break;
                case Color.Green:
                    Console.WriteLine("color: green");
                    break;
                case Color.Yellow:
                    Console.WriteLine("color: yellow");
                    break;
                case Color.Gray:
                    Console.WriteLine("color: gray");
                    break;
                case Color.Pink:
                    Console.WriteLine("color: pink");
                    break;
            }
        }

        public void F2(int n1, int n2, Numb res)
        {
            int result = res switch
            {
                Numb.Add => n1 + n2,
                Numb.Subtract => n1 - n2,
                Numb.Multiply => n1 * n2,
                Numb.Divide => n1 / n2
            };
            Console.WriteLine(result);
        }
    }
    enum Color
    {
        Blue,
        Green,
        Yellow,
        Gray,
        Pink
    }

    enum Numb
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}