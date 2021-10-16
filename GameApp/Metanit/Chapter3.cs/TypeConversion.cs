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
}