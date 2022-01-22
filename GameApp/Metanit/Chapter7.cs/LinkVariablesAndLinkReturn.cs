using System;

namespace LinkVariablesAndLinkReturn
{
    class C1
    {
        static void F1()
        {
            int n1 = 1;
            ref int n2 = ref n1;
            Console.WriteLine(n1);
            n2 = 2;
            Console.WriteLine(n1);
            n1 = 3;
            Console.WriteLine(n2);


            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            ref int arr1Ref = ref Find(4, arr1);
            arr1Ref = 9;
            Console.WriteLine(arr1[3]);

            ref int Find(int number, int[] arr1)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == number)
                    {
                        return ref arr1[i];
                    }
                }
                throw new IndexOutOfRangeException("число не найдено");
            }


            int n3 = 5;
            int n4 = 8;
            ref int n5 = ref Max(ref n3, ref n4);
            n5 = 34;
            Console.WriteLine($"a: {n3}  b: {n4}");

            ref int Max(ref int n1, ref int n2)
            {
                if (n1 > n2)
                {
                    return ref n1;
                }

                else
                {
                    return ref n2;
                }
            }
        }
    }
}