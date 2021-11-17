using System;

namespace ExceptionGenerationAndTheThrowStatement
{
    class C1
    {
        static void F1()
        {
            try
            {
                Console.WriteLine("Number: ");
                string s1 = Console.ReadLine();
                if (s1.Length > 1 && s1.Length < 10)
                {
                    throw new Exception("Length > 10 sumbol");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mistake: {ex.Message}");
            }

        }
    }

    class C2
    {
        static void F2()
        {
            try
            {
                try
                {
                    Console.Write("String: ");
                    string s2 = Console.ReadLine();
                    if (s2.Length < 10 && s2.Length > 15)
                    {
                        throw new Exception("Length < 10 sumbol or length > 15 sumbol");
                    }
                }
                catch
                {
                    Console.WriteLine("Exeption");
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