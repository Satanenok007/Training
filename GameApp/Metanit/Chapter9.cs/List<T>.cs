using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };
            numbers.Add(6);

            numbers.AddRange(new int[] { 7, 8, 9 });

            numbers.Insert(0, 666);

            numbers.RemoveAt(1);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Том" });
            people.Add(new Person() { Name = "Билл" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}