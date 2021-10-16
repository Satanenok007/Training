using System;
using System.Collections.Generic;

namespace LinkedLink
{
    class Persons
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void MainLinkedLink(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddLast(1);
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            LinkedList<Persons> persons = new LinkedList<Persons>();

            LinkedListNode<Persons> tom = persons.AddLast(new Persons() { Name = "Mike" });
            persons.AddLast(new Persons() { Name = "John" });
            persons.AddFirst(new Persons() { Name = "Bill" });

            Console.WriteLine(tom.Previous.Value.Name);
            Console.WriteLine(tom.Next.Value.Name);
        }
    }
}