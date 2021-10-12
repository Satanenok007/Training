using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddLast(1);
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            LinkedList<Person> persons = new LinkedList<Person>();

            LinkedListNode<Person> tom = persons.AddLast(new Person() { Name = "Mike" });
            persons.AddLast(new Person() { Name = "John" });
            persons.AddFirst(new Person() { Name = "Bill" });

            Console.WriteLine(tom.Previous.Value.Name);
            Console.WriteLine(tom.Next.Value.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}