using System;

namespace Concealment
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Info()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class Student : Person
    {
        public int Group { get; set; }
        public Student(string firstName, string lastName, int group)
                : base(firstName, lastName)
        {
            Group = group;
        }
        public new void Info()
        {
            Console.WriteLine($"{FirstName} {LastName} работает в {Group}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Alise", "Robertson");
            bob.Info();

            Student stud1 = new Student("Sofia", "Kmita", 586);
            stud1.Info();
        }
    }

    class Concealment
    {
        class ExampleBase
        {
            public readonly int x = 10;
            public const int G = 5;
        }
        class ExampleDerived : ExampleBase
        {
            public new readonly int x = 20;
            public new const int G = 15;
        }
    }

    class Example2
    {
        class FirstClass
        {
            public void DoSomthing()
            {
                Console.WriteLine("FirstClass.DoSomething");
            }
        }
        class SecondClass : FirstClass
        {
            public new void DoSomthing()
            {
                Console.WriteLine("SecondClass.DoSomething");
            }
        }


    }
}