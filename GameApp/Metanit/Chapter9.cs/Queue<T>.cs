using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3);
            numbers.Enqueue(5);
            numbers.Enqueue(8);

            int queueElement = numbers.Dequeue();
            Console.WriteLine(queueElement);

            Queue<Person> persons = new Queue<Person>();
            persons.Enqueue(new Person() { Name = "Maison" });
            persons.Enqueue(new Person() { Name = "Billi" });
            persons.Enqueue(new Person() { Name = "John" });

            Person pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);

            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            Person person = persons.Dequeue();
            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}