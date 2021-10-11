using System;

namespace Records
{
    class ComparisonForEquality
    {
        static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Joch" };
            var person2 = new Person() { Name = "Joch" };
            Console.WriteLine(person1.Equals(person2));

            var user1 = new User() { Name = "Lina" };
            var user2 = new User() { Name = "Lina" };
            Console.WriteLine(user1.Equals(user2));
        }
    }

    public record Person
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    public class User
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    class PositionalRecords
    {
        public record Person(string Name, int Age);
        static void Main(string[] args)
        {
            var person = new Person("Rick", 27);
            Console.WriteLine(person.Name);

            var (userName, userAge) = person;

            Console.WriteLine(userAge);
            Console.WriteLine(userName);
        }
    }
}