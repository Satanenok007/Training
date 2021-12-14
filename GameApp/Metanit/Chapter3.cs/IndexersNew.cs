using System;

namespace Indexer
{
    class C1
    {
        static void F1()
        {
            C2 n1 = new C2();
            n1["obj1"] = "1";
            Console.WriteLine(n1["obj1"]);
            n1["obj2"] = "2";
            Console.WriteLine(n1["obj2"]);
            n1["obj3"] = "3";
            Console.WriteLine(n1["obj3"]);


            C3 n2 = new C3();
            n2["obj4"] = "4";
            Console.WriteLine(n2["obj4"]);

            n2["obj5"] = "5";
            Console.WriteLine(n2["obj5"]);

            n2["obj6"] = "6";
            Console.WriteLine(n2["obj6"]);

            n2["obj7"] = "7";
            Console.WriteLine(n2["obj7"]);


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
        string obj1;
        string obj2;
        string obj3;

        public string this[string parameters]
        {
            get
            {
                switch (parameters)
                {
                    case "obj1": return "string:" + obj1;
                    case "obj2": return obj2;
                    case "obj3": return obj3;
                    default: return null;
                }
            }
            set
            {
                switch (parameters)
                {
                    case "obj1":
                        obj1 = value;
                        break;
                    case "obj2":
                        obj2 = value;
                        break;
                    case "obj3":
                        obj3 = value;
                        break;
                }
            }
        }
    }

    class C3
    {
        string obj4;
        string obj5;
        string obj6;
        string obj7;

        public string this[string parameters]
        {
            get
            {
                switch (parameters)
                {
                    case "obj4": return obj4;
                    case "obj5": return obj5 + 10;
                    case "obj6": return "string" + obj6;
                    case "obj7": return "string:" + obj7 + " " + 10;
                    default: return null;
                }
            }
            set
            {
                switch (parameters)
                {
                    case "obj4":
                        obj4 = value;
                        break;
                    case "obj5":
                        obj5 = value;
                        break;
                    case "obj6":
                        obj6 = value;
                        break;
                    case "obj7":
                        obj7 = value;
                        break;
                }
            }
        }
    }

    class C4
    {
        private int[,] arr = new int[,] { { 10, 32, 30 }, { 21, 55, 23 }, { 70, 18, 44 } };
        public int this[int y, int x]
        {
            get
            {
                return arr[y, x];
            }
            set
            {
                arr[y, x] = value;
            }
        }
    }
}