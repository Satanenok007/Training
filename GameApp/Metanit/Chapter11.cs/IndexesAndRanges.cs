using System;

namespace IndexesAndRanges
{
    class C1
    {
        static void F1()
        {
            Index ind1 = 2;
            Index ind2 = ^2;

            string[] arr1 = { "0", "1", "2", "3", "4", "5" };
            string res1 = arr1[ind1];
            string res2 = arr1[ind2];
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            string[] res3 = arr1[1..5];
            foreach (var r1 in res3)
            {
                Console.WriteLine(r1);
            }

            string[] obj1 = arr1[1..];
            string[] obj2 = arr1[..3];
            string[] obj3 = arr1[^2..];
            string[] obj4 = arr1[..^4];
            string[] obj5 = arr1[^2..^1];
        }
    }
}