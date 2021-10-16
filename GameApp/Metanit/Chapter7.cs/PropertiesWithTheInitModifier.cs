using System;

namespace PropertiesWithTheInitModifier
{
    class SettingAPropertyViaAnInitializer
    {
        static void MainSettingAPropertyViaAnInitializer(string[] args)
        {
            var person = new Person() { Name = "Maison" };
            Console.WriteLine(person.Name);
        }
    }

    public class Person
    {
        public string Name { get; init; }
    }

    class SettingAPropertyViaTheConstructor
    {
        static void MainSettingAPropertyViaAnInitializer(string[] args)
        {
            var person = new Persons("Sofia");
            Console.WriteLine(person.Name);
        }
    }

    public class Persons
    {
        public Persons(string name)
        {
            Name = name;
        }
        public string Name { get; init; }
        public int Age { get; set; }
    }

    class SettingThePropertyInitializerWithTheInitModifier
    {
        static void MainSettingThePropertyInitializerWithTheInitModifier(string[] args)
        {
            var person = new People() { Name = "Mike" };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Email);
        }
    }

    public class People
    {
        readonly string name;
        public string Name
        {
            get { return name; }
            init
            {
                name = value;
                Email = $"{value}@gmail.com";
            }
        }
        public string Email { get; init; }
    }

    class ComparisonWithReadonlyProperties
    {
        public class Person
        {
            public Person(string n)
            {
                Name = n;
            }
            public string Name { get; }
        }
    }
}