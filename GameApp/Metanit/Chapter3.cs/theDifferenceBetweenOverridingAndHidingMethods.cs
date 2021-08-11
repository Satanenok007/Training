using System;
namespace TheDifferenceBetweenOverridingAndHidingMethods
{
    class redefinition
    {
        class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
            public virtual void Display()
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

            public override void Display()
            {
                Console.WriteLine($"{Name} работает в {Company}");
            }
        }

        public static void Main(string[] args)
        {
            Person tom = new Employee("Tom", "Microsoft");
            tom.Display();      // Tom работает в Microsoft
        }
    }

    class concealment
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

        public static void Main(string[] args)
        {
            Person tom = new Employee("Tom", "Microsoft");
            tom.Display();      // Tom
        }
    }
}