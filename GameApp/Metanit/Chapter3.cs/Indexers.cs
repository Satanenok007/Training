using System;

namespace Indexers
{
    class Program
    {
        class Person
        {
            string name;
            string email;
            string phone;

            public string this[string propname]
            {
                get
                {
                    switch (propname)
                    {
                        case "name": return "Mr/Ms. " + name;
                        case "email": return email;
                        case "phone": return phone;
                        default: return null;
                    }
                }
                set
                {
                    switch (propname)
                    {
                        case "name":
                            name = value;
                            break;
                        case "email":
                            email = value;
                            break;
                        case "phone":
                            phone = value;
                            break;
                    }
                }
            }
            class Program
            {
                static void MainPorgrams(string[] args)
                {
                    Person p1 = new Person();
                    p1["name"] = "Sofia";
                    p1["emaul"] = "SofiaKmita@gmail.com";
                    p1["phone"] = "+375292171296";
                    Console.WriteLine(p1["name"]);
                }
            }
        }

        class Matrix
        {
            private int[,] numb = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
            public int this[int x, int y]
            {
                get
                {
                    return numb[x, y];
                }
                set
                {
                    numb[x, y] = value;
                }
            }

            class Program
            {
                static void MainMatrix(string[] args)
                {
                    Matrix matrix = new Matrix();
                    Console.WriteLine(matrix[0, 0]);
                    matrix[0, 0] = 111;
                    Console.WriteLine(matrix[0, 0]);
                }
            }
        }
    }

    class C1
    {
        string fimls;
        string serials;
        string anime;

        public string this[string name]
        {
            get
            {
                switch (name)
                {
                    case "films": return fimls;
                    case "serials": return serials;
                    case "anime": return anime;
                    default: return null;
                }
            }
            set
            {
                switch (name)
                {
                    case "films":
                        fimls = value;
                        break;
                    case "serials":
                        serials = value;
                        break;
                    case "anime":
                        anime = value;
                        break;
                }
            }
        }
        class Program
        {
            static void MainPorgrams(string[] args)
            {
                C1 result = new C1();
                result["films"] = "Silence of the Lambs";
                result["emaul"] = "Riverdale";
                result["phone"] = "My neighbor Tottoro";
                Console.WriteLine(result["name"]);
            }
        }
    }
}