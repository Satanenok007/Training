using System;

namespace FormattingAndInterpolatingStrings
{
    class C1
    {
        static void F1()
        {
            string obj1 = "aaa";
            int obj2 = 1;
            Console.WriteLine("obj1: {0}  obj2: {1}", obj1, obj2);

            string obj3 = "bbb";
            int obj4 = 2;
            string res1 = string.Format("obj3: {0}  obj4: {1}", obj3, obj4);
            Console.WriteLine(res1);

            double obj5 = 3.1;
            string re2 = string.Format("{0:C0}", obj5);
            Console.WriteLine(re2);
            string res3 = string.Format("{0:C2}", obj5);
            Console.WriteLine(res3);


            int obj6 = 4;
            string res4 = string.Format("{0:d}", obj6);
            Console.WriteLine(re2);
            string res5 = string.Format("{0:d4}", obj6);
            Console.WriteLine(res3);


            int obj7 = 5;
            string res6 = string.Format("{0:f}", obj7);
            Console.WriteLine(res6);

            double obj8 = 6.01;
            string res7 = string.Format("{0:f4}", obj8);
            Console.WriteLine(res7);

            double obj9 = 7.02;
            string res8 = string.Format("{0:f1}", obj9);
            Console.WriteLine(res8);


            decimal obj10 = 8.024m;
            Console.WriteLine("{0:P1}", obj10);

            long obj11 = 375256843991;
            string res9 = string.Format("{0:+### (##) ###-##-##}", obj11);
            Console.WriteLine(res9);


            long obj12 = 375336843991;
            Console.WriteLine(obj12.ToString("+### (##) ###-##-##"));

            double obj13 = 9.011;
            Console.WriteLine(obj13.ToString("C2"));

            string obj14 = "ccc";
            int obj15 = 10;
            Console.WriteLine($"obj14: {obj14}  obj15: {obj15}");

            int a = 9;
            int b = 10;
            string result = $"{a} * {b} = {a * b}";
            Console.WriteLine(result);

            int c = 11;
            int d = 12;
            string res10 = $"{c} * {d} = {Multiply(c, d)}";
            Console.WriteLine(result);
            int Multiply(int a, int b) => a * b;

            long obj16 = 375256843991;
            Console.WriteLine($"{obj16:+### ## ### ## ##}");

            string obj17 = "ddd";
            int obj18 = 13;

            Console.WriteLine($"obj17: {obj17,-5} obj18: {obj18}");
            Console.WriteLine($"ob18: {obj17,5} ob18: {obj18}");
        }
    }
}