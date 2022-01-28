using System;

namespace StringsAndTheStringClass
{
    class C1
    {
        static void F1(string[] args)
        {
            string s1 = "s1";
            string s2 = new String('w', 6);
            string s3 = new String(new char[] { 'a', 'b', 'c', 'd', 'e' });
            string s4 = new String(new char[] { 'a', 'b', 'c', 'd', 'e' }, 1, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);


            string s5 = "s5";
            char c1 = s5[1];
            Console.WriteLine(c1);
            Console.WriteLine(s5.Length);


            string s6 = "s6";

            for (var x = 0; x < s6.Length; x++)
            {
                Console.WriteLine(s6[x]);
            }
            foreach (var ch in s6)
            {
                Console.WriteLine(ch);
            }


            string s7 = "s7";
            string s8 = "s8";

            Console.WriteLine(s7 == s8);
        }
    }
}