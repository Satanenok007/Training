using System;

namespace SortingObjectsIComparableInterface
{
    class MethodSort
    {
        static void Main()
        {
            int[] numbers = new int[] { 97, 45, 32, 65, 83, 23, 15 };
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }

    class MethodIComparable
    {
        public interface IComparable
        {
            int CompareTo(object o);
        }
    }

    class MethodCompareTo
    {
        class Person : IComparable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CompareTo(object o)
            {
                Person p = o as Person;
                if (p != null)
                {
                    return this.Name.CompareTo(p.Name);
                }
                else
                {
                    throw new Exception("Невозможно сравнить два объекта");
                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Person p1 = new Person { Name = "Mike", Age = 17 };
                Person p2 = new Person { Name = "Rubbi", Age = 23 };
                Person p3 = new Person { Name = "Maison", Age = 19 };

                Person[] people = new Person[] { p1, p2, p3 };
                Array.Sort(people);

                foreach (Person p in people)
                {
                    Console.WriteLine($"{p.Name} - {p.Age}");
                }
            }
        }
    }

    class ApplicationOfTheComparator
    {
        interface IComparer
        {
            int Compare(object o1, object o2);
        }
        class Person : IComparable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CompareTo(object o)
            {
                Person p = o as Person;
                if (p != null)
                {
                    return this.Name.CompareTo(p.Name);
                }
                else
                {
                    throw new Exception("Невозможно сравнить два объекта");
                }
            }
        }
        class PeopleComparer
        {
            public int Compare(Person p1, Person p2)
            {
                if (p1.Name.Length > p2.Name.Length)
                {
                    return 1;
                }
                else if (p1.Name.Length < p2.Name.Length)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person p1 = new Person { Name = "Sofia", Age = 34 };
                Person p2 = new Person { Name = "Nastya", Age = 23 };
                Person p3 = new Person { Name = "Naiton", Age = 21 };

                Person[] people = new Person[] { p1, p2, p3 };
                Array.Sort(people);

                foreach (Person p in people)
                {
                    Console.WriteLine($"{p.Name} - {p.Age}");
                }
            }
        }
    }
}