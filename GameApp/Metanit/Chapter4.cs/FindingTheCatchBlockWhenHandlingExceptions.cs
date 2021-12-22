using System;

namespace FindingTheCatchBlockWhenHandlingExceptions
{
    class C1
    {
        static void F1(string[] args)
        {
            try
            {
                C2.F2();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch F1 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally F1");
            }
            Console.WriteLine("end method F1");
        }
    }
    class C2
    {
        public static void F2()
        {
            try
            {
                F3();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catch F2 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally F2");
            }
            Console.WriteLine("end method F2");
        }
        static void F3()
        {
            try
            {
                int n1 = 10;
                int n2 = n1 / 0;
            }
            finally
            {
                Console.WriteLine("Finally F3");
            }
            Console.WriteLine("end method F3");
        }
    }
}