using System;

namespace AbstractClassesAndClassMembers
{
    class Program
    {
        abstract class Human
        {
            public int Length { get; set; }
            public int Weigth { get; set; }
        }


        abstract class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public abstract void Display();
        }

        class Client : Person
        {
            public int Sum { get; set; }

            public Client(string name, int sum)
                : base(name)
            {
                Sum = sum;
            }
            public override void Display()
            {
                Console.WriteLine($"{Name} имеет счет на сумму {Sum}");
            }
        }

        class Employee : Person
        {
            public string Position { get; set; }

            public Employee(string name, string position)
                : base(name)
            {
                Position = position;
            }
            public override void Display()
            {
                Console.WriteLine($"{Position} {Name}");
            }
        }

        public static void Main(string[] args)
        {
            Person client = new Client("Tom", 500);
            Person employee = new Employee("Bob", "Операционист");
        }



        abstract class Persons
        {
            public abstract string names { get; set; }
        }

        class Clients : Persons
        {
            private string name;

            public override string names
            {
                get { return "Mr/Ms. " + name; }
                set { name = value; }
            }
        }

        class Employees : Persons
        {
            public override string names { get; set; }
        }
    }
}