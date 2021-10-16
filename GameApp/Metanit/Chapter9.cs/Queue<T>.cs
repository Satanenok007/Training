using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        class Persons
        {
            public string Name { get; set; }
        }
        static void MainQueue(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3);
            numbers.Enqueue(5);
            numbers.Enqueue(8);

            int queueElement = numbers.Dequeue();
            Console.WriteLine(queueElement);

            Queue<Persons> persons = new Queue<Persons>();
            persons.Enqueue(new Persons() { Name = "Maison" });
            persons.Enqueue(new Persons() { Name = "Billi" });
            persons.Enqueue(new Persons() { Name = "John" });

            Persons pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);

            foreach (Persons p in persons)
            {
                Console.WriteLine(p.Name);
            }

            Persons person = persons.Dequeue();
            Console.WriteLine(person.Name);
        }
    }
}