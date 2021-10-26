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

    class C1
    {
        class User
        {
            public string Name { get; set; }

            public User(string name)
            {
                Name = name;
            }

            public void Info()
            {
                Console.WriteLine(Name);
            }
        }

        class Order : User
        {
            public string Email { get; set; }

            public Order(string name, string email)
                : base(name)
            {
                Email = email;
            }
        }
        class Program
        {
            static void F1(string[] args)
            {
                User user1 = new User("Mike");
                user1.Info();
                Order order1 = new Order("Mike", "MMikeHandson@gmail.com");
                order1.Info();
            }
        }
    }
}