using System;
namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }
    }
    class Program
    {
        static void MainPerson(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display();
            Employee emp = new Employee("Tom", "Microsoft");
            emp.Display();
            Console.Read();
        }
    }

    class TheOrderOfCallingConstructors
    {
        class Person
        {
            string name;
            int age;

            public Person(string name)
            {
                this.name = name;
                Console.WriteLine("Person(string name)");
            }
            public Person(string name, int age) : this(name)
            {
                this.age = age;
                Console.WriteLine("Person(string name, int age)");
            }
        }
        class Employee : Person
        {
            string company;

            public Employee(string name, int age, string company) : base(name, age)
            {
                this.company = company;
                Console.WriteLine("Employee(string name, int age, string company)");
            }
        }

        class Progmam
        {
            static void MainProg(string[] args)
            {
                Employee person1 = new Employee("Alise", 25, "Microsoft");
            }
        }
    }
}