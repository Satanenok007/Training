using System;

namespace TestAnonymousMethods
{
    class C1
    {
        delegate void delegate1(string message);
        delegate int delegate2(int a, int b);
        static void F1()
        {
            delegate1 del1 = delegate (string message)
            {
                Console.WriteLine(message);
            };
            del1("del1");

            delegate1 del2 = delegate
            {
                Console.WriteLine("anonymous method");
            };
            del2("del2");

            F2("del1", delegate (string mess)
            {
                Console.WriteLine(mess);
            });

            static void F2(string message, delegate1 del1)
            {
                del1(message);
            }

            int c = 10;
            delegate2 del3 = delegate (int a, int b)
            {
                return a + b + c;
            };
            int result = del3(2, 9);
            Console.WriteLine(del3);
        }
    }
}