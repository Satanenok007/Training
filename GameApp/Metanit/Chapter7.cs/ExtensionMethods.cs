using System;

namespace ExtensionMethods
{
    class C1
    {
        static void F1(string[] args)
        {
            string obj1 = "Массив";
            char obj2 = 'w';
            int obj3 = obj1.F2(obj2);
            Console.WriteLine(obj3);
        }
    }

    public static class C2
    {
        public static int F2(this string str, char c)
        {
            int count = 0;
            for (int x = 0; x < str.Length; x++)
            {
                if (str[x] == c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}