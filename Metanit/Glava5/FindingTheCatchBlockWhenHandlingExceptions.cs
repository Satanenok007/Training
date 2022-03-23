using System;

namespace FindingTheCatchBlockWhenHandlingExceptions
{
    class A
    {
        static void F1()
        {
            try
            {
                B.F2();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch in F1: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally in F1");
            }
            Console.WriteLine("End F1");
        }
    }

    class B
    {
        public static void F2()
        {
            try
            {
                F3();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catch in F2 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally in F2");
            }
            Console.WriteLine("End F2");
        }
        static void F3()
        {
            try
            {
                int a = 2;
                int b = a / 0;
            }
            finally
            {
                Console.WriteLine("Finally in F3");
            }
            Console.WriteLine("End F3");
        }
    }
}