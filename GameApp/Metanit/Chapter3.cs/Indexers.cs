using System;

namespace Indexers
{
    class C1
    {
        static void F1()
        {
            C2 n1 = new C2();
            n1["s1"] = "str1";
            Console.WriteLine(n1["s1"]);
            n1["s2"] = "str2";
            Console.WriteLine(n1["s2"]);
            n1["s3"] = "str3";
            Console.WriteLine(n1["s3"]);


            C3 n2 = new C3();
            n2["s4"] = "str4";
            Console.WriteLine(n2["s4"]);

            n2["s5"] = "str5";
            Console.WriteLine(n2["s5"]);

            n2["s6"] = "str6";
            Console.WriteLine(n2["s6"]);

            n2["s7"] = "str7";
            Console.WriteLine(n2["s7"]);


            C4 array1 = new C4();
            Console.WriteLine(array1[0, 0]);
            array1[0, 0] = 1;
            Console.WriteLine(array1[0, 0]);

            Console.WriteLine(array1[1, 1]);
            array1[1, 1] = 2;
            Console.WriteLine(array1[1, 1]);

            Console.WriteLine(array1[2, 2]);
            array1[2, 2] = 3;
            Console.WriteLine(array1[2, 2]);
        }
    }
    class C2
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

    class C3
    {
        string s4;
        string s5;
        string s6;
        string s7;

        public string this[string parameters]
        {
            get
            {
                switch (parameters)
                {
                    case "s4": return s4;
                    case "s5": return s5 + 10;
                    case "s6": return "string" + s6;
                    case "s7": return "string:" + s7 + " " + 10;
                    default: return null;
                }
            }
            set
            {
                switch (parameters)
                {
                    case "s4":
                        s4 = value;
                        break;
                    case "s5":
                        s5 = value;
                        break;
                    case "s6":
                        s6 = value;
                        break;
                    case "s7":
                        s7 = value;
                        break;
                }
            }
        }
    }

    class C4
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


}