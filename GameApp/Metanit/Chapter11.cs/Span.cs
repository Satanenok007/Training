using System;

namespace Span
{
    class C1
    {
        static void F1()
        {
            string[] obj1 = new string[] { "1", "2", "3" };
            Span<string> obj1Span = obj1;
            obj1Span[1] = "2.5";
            Console.WriteLine(obj1Span[2]);
            Console.WriteLine(obj1Span.Length);

            foreach (var ob1 in obj1Span)
            {
                Console.WriteLine(ob1);
            }


            int[] temperatures = new int[]
            {
                10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
                18, 16, 15, 16, 17, 14, 9, 8, 10, 11,
                12, 14, 15, 15, 16, 15, 13, 12, 12, 11
            };
            Span<int> temperaturesSpan = temperatures;

            Span<int> firstDecade = temperaturesSpan.Slice(0, 18);

            temperaturesSpan[0] = 12;
            Console.WriteLine(firstDecade[0]);



            string obj2 = "paradise in hell";
            string obj3 = obj2.Substring(startIndex: 9, length: 4);
            ReadOnlySpan<char> obj4 = obj2.AsSpan().Slice(start: 9, length: 4);
            Console.WriteLine(obj4[0]);

            foreach (var ob4 in obj4)
            {
                Console.Write(ob4);
            }
        }
    }
}