using System;

namespace PatternMatching
{
    class C1
    {
        static void F1()
        {
            C2 obj1 = new C3();
            Result(obj1);

            void Result(C2 obj)
            {
                if (obj is C3 c3 && c3.Res == false)
                {
                    c3.F2();
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            C2 obj2 = new C2();
            C2 obj3 = new C2();
            Res(obj3);
            Res(obj2);

            void Res(C2? obj)
            {
                switch (obj)
                {
                    case C3 c3:
                        c3.F2();
                        break;
                    case null:
                        Console.WriteLine("Object is null");
                        break;
                    default:
                        Console.WriteLine("Object is not c3");
                        break;
                }
            }

            var reslt = "True";

            if (reslt is "True")
            {
                Console.WriteLine("True");
            }



            C4 obj4 = new C4 { S3 = "3", S2 = "2", S1 = "1" };
            C4 obj5 = new C4 { S3 = "6", S2 = "5", S1 = "4" };
            C4 obj6 = new C4 { S3 = "9", S2 = "8", S1 = "7" };

            F3(obj6);
            F3(obj4);
            F3(obj5);

            void F3(C4 c4)
            {
                if (c4 is C4 { S3: "3", S2: "2" })
                {
                    Console.WriteLine("Numb: 2");
                }
                else if (c4 is C4 { S3: "6" })
                {
                    Console.WriteLine("Numb: 6");
                }
                else
                {
                    Console.WriteLine("Numb");
                }
            }


            var obj7 = new C6("7");
            var obj8 = new C6("8");
            var obj9 = new C5("obj", obj7);
            var obj10 = new C5("obj", obj8);

            F4(obj9);
            F4(obj10);

            void F4(C5 c5)
            {
                if (c5 is C5 { c6: { S5: "s5" } })
                {
                    Console.WriteLine($"{c5.S4} www");
                }
                else
                {
                    Console.WriteLine($"{c5.S4} xxxx");
                }
            }


            string F5(string lang, string daytime) => (lang, daytime) switch
            {
                ("english", "morning") => "Good morning",
                ("english", "evening") => "Good evening",
                ("german", "morning") => "Guten Morgen",
                ("german", "evening") => "Guten Abend",
                _ => "Здрасьть"
            };

            string mess = F5("english", "evening");
            Console.WriteLine(mess);

            mess = F5("french", "morning");
            Console.WriteLine(mess);



            string TimeOfDay(C7 details) => details switch
            {
                ("english", "morning", _) => "Good morning",
                ("english", "evening", _) => "Good evening",
                ("german", "morning", _) => "Guten Morgen",
                ("german", "evening", _) => "Guten Abend",
                (_, _, "admin") => "Hello, Admin",
                _ => "Здрасьть"
            };


            C7 obj11 = new C7 { S5 = "english", S6 = "evening", S7 = "user" };
            string obj12 = TimeOfDay(obj11);
            Console.WriteLine(obj12);

            C7 obj13 = new C7 { S5 = "french", S6 = "morning", S7 = "admin" };
            obj12 = TimeOfDay(obj13);
            Console.WriteLine(obj12);


            decimal Calculate(decimal sum)
            {
                return sum switch
                {
                    <= 0 => 0,
                    < 22000 => sum * 0.02m,
                    < 920000 => sum * 0.9m,
                    _ => sum * 0.2m
                };
            }

            Console.WriteLine(Calculate(100));
            Console.WriteLine(Calculate(0));
            Console.WriteLine(Calculate(22000));
            Console.WriteLine(Calculate(91000));
            Console.WriteLine(Calculate(490000));



            string Numb(int numb)
            {
                return numb switch
                {
                    < 1 or > 110 => "numb > 110",
                    >= 1 and < 18 => "numb < 18",
                    _ => "available numb"
                };
            }

            Console.WriteLine(Numb(200));
            Console.WriteLine(Numb(0));
            Console.WriteLine(Numb(17));
            Console.WriteLine(Numb(18));
            Console.WriteLine(Numb(21));


            string CheckAge(int age) => age switch
            {
                not 35 => "Обычный возраст",
                _ => "Вам 35 года"
            };

            Console.WriteLine(CheckAge(35));
            Console.WriteLine(CheckAge(21));
        }
    }


    class C2
    {
        public virtual void F2() => Console.WriteLine("C2");
    }

    class C3 : C2
    {
        public override void F2() => Console.WriteLine("C3");
        public bool Res { get; set; }
    }

    class C4
    {
        public string S1 { get; set; } = "";
        public string S2 { get; set; } = "";
        public string S3 { get; set; } = "";
    }


    class C5
    {
        public string S4 { get; }
        public C6 c6 { get; set; }
        public C5(string s4, C6 C6)
        {
            S4 = s4;
            c6 = C6;
        }

    }
    class C6
    {
        public string S5 { get; }
        public C6(string s5) => S5 = s5;
    }

    class C7
    {
        public string S5 { get; set; } = "";
        public string S6 { get; set; } = "";
        public string S7 { get; set; } = "";

        public void Deconstruct(out string s5, out string s6, out string s7)
        {
            s5 = S5;
            s6 = S6;
            s7 = S7;
        }
    }
}