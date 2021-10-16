using System;

namespace LocalFunctions
{
    class Program
    {
        static void MainLocalFunctions(string[] args)
        {
            var result = GetResult(new int[] { -3, -2, -1, 0, 1, 2, 3 });
            Console.WriteLine(result);
        }
        static int GetResult(int[] numbers)
        {
            static bool IsMoreThan(int number)
            {
                int limit = 0;
                return number > limit;
            }

            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsMoreThan(numbers[i]))
                    result += numbers[i];
            }
            return result;
        }
    }
}