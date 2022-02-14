using System;

namespace AnonymousMethods
{
    class C1
    {
        delegate void Del1(string mess);
        delegate int Del2(int x, int y);
        static void F1()
        {
            Del1 d1 = delegate (string mess)
            {
                Console.WriteLine(mess);
            };
            d1("del1");

            Del1 d2 = delegate
            {
                Console.WriteLine("anonymous method");
            };
            d2("d2");

            Info("d1", delegate (string mess)
            {
                Console.WriteLine(mess);
            });

            static void Info(string message, Del1 del1)
            {
                del1(message);
            }

            int z = 10;
            Del2 d3 = delegate (int x, int y)
            {
                return x + y + z;
            };
            int result = d3(2, 9);
            Console.WriteLine(d3);
        }
    }
}