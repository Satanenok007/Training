using System;

namespace Tuples
{
    class C1
    {
        static void F1(string[] args)
        {
            var obj1 = (count: 5, sum: 10);
            Console.WriteLine(obj1.count);
            Console.WriteLine(obj1.sum);

            var (s1, n1) = ("s1", 11);
            Console.WriteLine(s1);
            Console.WriteLine(n1);

            string obj2 = "obj2";
            string obj3 = "obj3";
            (obj2, obj3) = (obj3, obj2);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);


            int[] arr1 = { -1, -2, 0, 2, 1, -3, 3, 4, -4, 5 };

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        (arr1[i], arr1[j]) = (arr1[j], arr1[i]);
                    }
                }
            }

            Console.WriteLine("sort array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }


            var tuples = GetValuesData(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(obj1.count);
            Console.WriteLine(obj1.sum);

            (int sum, int count) GetValuesData(int[] numbers)
            {
                var result = (sum: 0, count: numbers.Length);
                foreach (var n in numbers)
                {
                    result.sum += n;
                }
                return result;
            }
        }
    }
}