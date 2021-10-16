using System;

namespace Reenactors
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }
    }

    class Program
    {
        static void MainReenactors(string[] args)
        {
            Person p1 = new Person { Name = "Mike", Age = 23 };

            (string name, int age) = p1;

            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}