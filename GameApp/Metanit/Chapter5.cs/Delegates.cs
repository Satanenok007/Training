using System;

namespace Delegates
{
    class C1
    {
        delegate void Message();

        static void F1(string[] args)
        {
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = F2;
            }
            else
            {
                mes = F3;
            }
            mes();
        }
        private static void F2()
        {
            Console.WriteLine("F2");
        }
        private static void F3()
        {
            Console.WriteLine("F3");
        }
    }

    class DelegateParametersAndResult
    {
        delegate int d1(int x, int y);

        static void F4(string[] args)
        {
            d1 del1 = F5;
            int result = del1(4, 5);
            Console.WriteLine(result);

            del1 = F6;
            result = del1(4, 5);
            Console.WriteLine(result);
        }
        private static int F5(int x, int y)
        {
            return x + y;
        }
        private static int F6(int x, int y)
        {
            return x * y;
        }
    }

    class DelegatesAsMethodParameters
    {
        delegate void del2();

        static void F7(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                ShowMessage(F8);
            }
            else
            {
                ShowMessage(F9);
            }
        }
        private static void ShowMessage(del2 _del)
        {
            _del?.Invoke();
        }
        private static void F8()
        {
            Console.WriteLine("F8");
        }
        private static void F9()
        {
            Console.WriteLine("F9");
        }
    }

    class GeneralizedDelegates
    {
        delegate T del3<T, R>(R val);

        class C2
        {
            static void F10(string[] args)
            {
                del3<decimal, int> op = Sum;

                Console.WriteLine(op(10));
            }

            static decimal Sum(int n1)
            {
                return n1 + n1;
            }
        }
    }
}