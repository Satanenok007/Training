using System;

namespace OperationsWithStrings
{
    class C1
    {
        static void F1()
        {
            string s1 = "s1";
            string s2 = "s2";
            string s3 = s1 + " " + s2;
            string s4 = string.Concat(s3, "!!!");
            Console.WriteLine(s4);

            int result = string.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }

            string s5 = "s5";
            string s6 = "s6";
            string s7 = "s7";
            string s8 = "s8";
            string s9 = "s9";
            string[] values = new string[] { s5, s6, s7, s8, s9 };

            string s10 = string.Join(" ", values);
            Console.WriteLine(s10);


            string s11 = "paradise in hell";
            char ch = 'a';
            int indexOfChar = s11.IndexOf(ch);
            Console.WriteLine(indexOfChar);


            var files = new string[]
            {
                "s.1",
                "s.2",
                "s.3",
                "s.4",
                "s.5"
            };

            for (int y = 0; y < files.Length; y++)
            {
                if (files[y].EndsWith(".3"))
                {
                    Console.WriteLine(files[y]);
                }
            }


            string s12 = "There is a heaven in hell";

            string[] words = s12.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }


            string s13 = "Hell paradise";
            s13 = s13.Substring(2);
            Console.WriteLine(s13);

            s13 = s13.Substring(0, s13.Length - 2);
            Console.WriteLine(s13);
        }
    }
}