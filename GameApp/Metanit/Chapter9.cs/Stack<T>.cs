using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> numbers = new Stack<int>();

            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(8);

            int stackElement = numbers.Pop();
            Console.WriteLine(stackElement);

            Stack<Person> persons = new Stack<Person>();
            persons.Push(new Person() { Name = "Sofia" });
            persons.Push(new Person() { Name = "Nastya" });
            persons.Push(new Person() { Name = "Maison" });

            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            Person person = persons.Pop();
            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}