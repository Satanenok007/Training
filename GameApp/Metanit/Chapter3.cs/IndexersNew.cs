using System;

namespace Indexers
{
    class C1
    {
        string s1;
        string s2;
        string s3;

        public string this[string parameters]
        {
            get
            {
                switch (parameters)
                {
                    case "s1": return "string:" + s1;
                    case "s2": return s2;
                    case "s3": return s3;
                    default: return null;
                }
            }
            set
            {
                switch (parameters)
                {
                    case "s1":
                        s1 = value;
                        break;
                    case "s2":
                        s2 = value;
                        break;
                    case "s3":
                        s3 = value;
                        break;
                }
            }
        }
    }

    class C2
    {
        private int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        public int this[int y, int x]
        {
            get
            {
                return array[y, x];
            }
            set
            {
                array[y, x] = value;
            }
        }
    }


    class C3
    {
        static void F1()
        {
            C1 n1 = new C1();
            n1["s1"] = "string 1";
            n1["s2"] = "string 2";
            n1["s3"] = "string 3";
            Console.WriteLine(n1["s1"]);
            Console.WriteLine(n1["s2"]);
            Console.WriteLine(n1["s3"]);

            C2 array1 = new C2();
            Console.WriteLine(array1[0, 0]);
            array1[0, 0] = 12;
            Console.WriteLine(array1[0, 0]);

            Console.WriteLine(array1[1,1]);
            array1[1,1] = 123;
            Console.WriteLine(array1[1,1]);

            Console.WriteLine(array1[2,2]);
            array1[2,2] = 1234;
            Console.WriteLine(array1[2,2]);
        }
    }
}