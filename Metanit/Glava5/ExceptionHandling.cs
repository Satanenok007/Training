using System;

namespace ExceptionHandling
{
    class A
    {
        static void F1()
        {
            try
            {
                int[] arr1 = new int[3];
                arr1[6] = 10;

                int a = 2;
                int b = a / 0;
                Console.WriteLine($"result: {b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception: DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("End");


            try
            {
                try
                {
                    Console.Write("Numb: ");
                    int? n1 = Console.ReadLine();
                    if (n1 == null || n1 < 3)
                    {
                        throw new Exception("number less than 3 characters");
                    }
                    else
                    {
                        Console.WriteLine($"numb: {n1}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}