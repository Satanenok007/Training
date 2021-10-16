using System;
using System.Collections.Generic;

namespace List
{
    class Persons
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void MainList(string[] args)
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

            List<Persons> people = new List<Persons>(3);
            people.Add(new Persons() { Name = "Holli" });
            people.Add(new Persons() { Name = "Bill" });

            foreach (Persons p in people)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}