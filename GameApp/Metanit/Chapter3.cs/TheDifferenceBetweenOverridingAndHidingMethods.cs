using System;

namespace TheDifferenceBetweenOverridingAndHidingMethods
{
    class Redefinition
    {
        class People
        {
            public string Name { get; set; }
            public People(string name)
            {
                Name = name;
            }
            public virtual void Info()
            {
                Console.WriteLine(Name);
            }
        }
        class Employee : People
        {
            public string Company { get; set; }
            public Employee(string name, string company)
                : base(name)
            {
                Company = company;
            }

            public override void Info()
            {
                Console.WriteLine($"{Name} работает в {Company}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                People tom = new Employee("Tom", "Microsoft");
                tom.Info();
            }
        }
    }


    class Concealment
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
            public new void Display()
            {
                Console.WriteLine($"{Name} работает в {Company}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person tom = new Employee("Tom", "Microsoft");
                tom.Display();
            }
        }
    }
}