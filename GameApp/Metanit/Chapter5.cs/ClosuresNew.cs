using System;

namespace Closures
{
    class C1
    {
        delegate int Delegate1(int n);
        static void F1(string[] args)
        {
            var obj1 = F2();
            obj1();
            obj1();
            obj1();

            Action F2()
            {
                int a = 5;
                void F3()
                {
                    a++;
                    Console.WriteLine(a);
                }
                return F3;
            }

            var obj2 = F4(5);

            Console.WriteLine(obj2(5));
            Console.WriteLine(obj2(6));
            Console.WriteLine(obj2(7));

            Delegate1 F4(int n1)
            {
                int F5(int n2)
                {
                    return n1 * n2;
                }
                return F5;
            }

        }
    }
}