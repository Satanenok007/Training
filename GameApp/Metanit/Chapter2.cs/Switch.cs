using System;
namespace Switch
{
    class C1
    {
        static void F1()
        {
            int x1 = 10;

            int res1 = F2(1, 10, 5);
            Console.WriteLine(res1);

            int res2 = F2(3, 10, 5);
            Console.WriteLine(res2);

            int res3 = F3(4, 1, 10);

            switch (x1)
            {
                case 1:
                    Console.WriteLine("x1 = 1");
                    goto case 2;
                case 2:
                    Console.WriteLine("x1 = 2");
                    break;
                default:
                    Console.WriteLine(" x1 = default");
                    break;
            }

            int F2(int x1, int x2, int x3)
            {
                switch (x1)
                {
                    case 1: return x2 + x3;
                    case 2: return x2 - x3;
                    case 3: return x2 * x3;
                    default: return 0;
                }
            }

            int F3(int x1, int x2, int x3)
            {
                return x1 switch
                {
                    1 => x2 + x3,
                    2 => x2 - x3,
                    3 => x2 * x3,
                    _ => 0
                };
            }
        }
    }
}