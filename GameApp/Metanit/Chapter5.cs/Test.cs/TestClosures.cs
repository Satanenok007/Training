using System;

namespace TestClosures
{
    delegate int Delegate1(int x);
    class C1
    {
        static void F1()
        {
            var obj1 = F2();
            obj1();
            obj1();
            obj1();

            Action F2()
            {
                int x = 5;
                void F3()
                {
                    x++;
                    Console.WriteLine(x);
                }
                return F3;
            }

            var obj2 = F4(4);

            Console.WriteLine(obj2(4));
            Console.WriteLine(obj2(10));
            Console.WriteLine(obj2(12));

            Delegate1 F4(int x)
            {
                int F5(int y)
                {
                    return x * y;
                }
                return F5;
            }
        }
    }
}