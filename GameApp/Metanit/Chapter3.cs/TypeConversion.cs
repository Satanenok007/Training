using System;

namespace TypeConversion
{
    class People
    {
        public string Name { get; set; }
        public People(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"People {Name}");
        }
    }

    class Student : People
    {
        public int Group { get; set; }
        public Student(string name, int group) : base(name)
        {
            Group = group;
        }
    }

    class Client : People
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }

    class Program
    {
        static void MainPeopleClass(string[] args)
        {
            Student student = new Student("Sofia", 586);
            People people1 = student;   // преобразование от Student к People
            People people2 = new Client("Alise", "MTB Bank");   // преобразование от Client к People

            Student student1 = new Student("Tom", 141);
            People people3 = student1;   // преобразование от Student к People


            // Объект Employee также представляет тип object
            object obj = new Student("Bill", 259);

            // чтобы обратиться к возможностям типа Student, приводим объект к типу Student
            Student stud = (Student)obj;

            // объект Client также представляет тип People
            People people4 = new Client("Sam", "ContosoBank");
            // преобразование от типа People к Client
            Client client = (Client)people4;

            Console.WriteLine(people1.Name);
            Console.ReadKey();
        }
    }

    class ConversionMethods
    {
        static void MainConversionMethods(string[] args)
        {
            People person1 = new People("Tom");
            Student stud1 = person1 as Student;
            if (stud1 == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine(stud1.Group);
            }


            People person2 = new People("Tom");
            try
            {
                Student stud2 = (Student)person2;
                Console.WriteLine(stud2.Group);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }


            People person3 = new People("Tom");
            if (person3 is Student)
            {
                Student stud3 = (Student)person3;
                Console.WriteLine(stud3.Group);
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
        }
    }

    class C1
    {
        class C2
        {
            public string c2 { get; set; }
            public C2(string _c2)
            {
                c2 = _c2;
            }
            public void Info()
            {
                Console.WriteLine($"C2: {c2}");
            }
        }

        class C3 : C2
        {
            public string c3 { get; set; }
            public C3(string c2, string _c3) : base(c2)
            {
                c3 = _c3;
            }

        }

        class C4 : C2
        {
            public string c4 { get; set; }
            public C4(string c2, string _c4) : base(c2)
            {
                c4 = _c4;
            }
        }

        class C5
        {
            static void F1(string[] args)
            {
                C3 n1 = new C3("Sofia", "Shop");
                C2 n2 = n1;
                Console.WriteLine(n2.c2);

                object n3 = new C3("Inna", "RedStrim");
                ((C2)n3).Info();
                Console.WriteLine(n3);

                C2 n4 = new C4("Nastya", "School");
                Console.WriteLine(n4);

                C4 n5 = (C4)n4;
            }
        }

        class MethodsOfTransformation
        {
            static void F2(string[] args)
            {
                C2 x1 = new C2("Mike");
                C3 x2 = x1 as C3;
                if (x2 == null)
                {
                    Console.WriteLine("Преобразование прошло неудачно");
                }
                else
                {
                    Console.WriteLine(x2.c3);
                }

                C2 x3 = new C2("Billi");
                try
                {
                    C3 x4 = (C3)x3;
                    Console.WriteLine(x4.c3);
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                C2 x5 = new C2("Jaison");
                if (x5 is C3)
                {
                    C3 x6 = (C3)x5;
                    Console.WriteLine(x6.c3);
                }
                else
                {
                    Console.WriteLine("Преобразование не допустимо");
                }
            }
        }
    }
}