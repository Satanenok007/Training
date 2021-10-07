using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            char c = 'i';
            int i = s.CharCount(c);
            Console.WriteLine(i);
        }
    }

    public static class StringExtension
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}