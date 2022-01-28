using System;
using System.Collections.Generic;

namespace IteratorsAndTheYieldOperator
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 numb = new C2();
            foreach (int n1 in numb)
            {
                Console.WriteLine(n1);
            }

            foreach (var n in 5)
            {
                Console.WriteLine(n);
            }
            foreach (var n in -5)
            {
                Console.WriteLine(n);
            }


            var obj1 = new C3[]
            {
                new C3("Tom"),
                new C3("Bob"),
                new C3("Sam")
            };
            var obj2 = new C4(obj1);

            foreach (C3 ob2 in obj2.GetS2(10))
            {
                Console.WriteLine(ob2.s1);
            }
        }
    }

    class C2
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int x = 0; x < 10; x++)
            {
                yield return x * x;
            }
        }
    }

    static class Int32Extension
    {
        public static IEnumerator<int> GetEnumerator(this int number)
        {
            int k = (number > 0) ? number : 0;
            for (int i = number - k; i <= k; i++) yield return i;
        }
    }


    class C3
    {
        public string s1 { get; }
        public C3(string s1) => this.s1 = s1;
    }
    class C4
    {
        C3[] s2;
        public C4(C3[] s2) => this.s2 = s2;
        public int Length => s2.Length;

        public IEnumerable<C3> GetS2(int max)
        {
            for (int x = 0; x < max; x++)
            {
                if (x == s2.Length)
                {
                    yield break;
                }
                else
                {
                    yield return s2[x];
                }
            }
        }
    }
}