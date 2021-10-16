using System;
using System.Collections.Generic;

namespace Stack
{
    class Persons
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void MainStack(string[] args)
        {

            Stack<int> numbers = new Stack<int>();

            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(8);

            int stackElement = numbers.Pop();
            Console.WriteLine(stackElement);

            Stack<Persons> persons = new Stack<Persons>();
            persons.Push(new Persons() { Name = "Sofia" });
            persons.Push(new Persons() { Name = "Nastya" });
            persons.Push(new Persons() { Name = "Maison" });

            foreach (Persons p in persons)
            {
                Console.WriteLine(p.Name);
            }

            Persons person = persons.Pop();
            Console.WriteLine(person.Name);
        }
    }
}