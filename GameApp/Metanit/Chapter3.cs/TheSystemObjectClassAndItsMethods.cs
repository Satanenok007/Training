using System;

namespace TheSystemObjectClassAndItsMethods
{
    class Program
    {
        private static void MainTheSystemObjectClassAndItsMethods(string[] args)
        {
            Person person1 = new Person { Name = "Alise" };

            Console.WriteLine(person1.GetType());


            object person2 = new Person { Name = "Billi" };

            if (person2.GetType() == typeof(Person))
            {
                Console.WriteLine("Это реально класс Person");
            }


            Person person3 = new Person { Name = "Sofi" };
            Person person4 = new Person { Name = "Bob" };
            Person person5 = new Person { Name = "Sofi" };
            bool p3Ep4 = person1.Equals(person2);   // false
            bool p3Ep5 = person1.Equals(person3);   // true
        }

        class Person
        {
            public string Name { get; set; }

            public override string ToString()
            {
                if (String.IsNullOrEmpty(Name))
                {
                    return base.ToString();
                }
                return Name;
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }


            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType())
                {
                    return false;
                }

                Person person = (Person)obj;
                return (this.Name == person.Name);
            }

        }
    }

    class Example2
    {
        class Program
        {
            static void MainExmp2(string[] args)
            {
                var m = Environment.Version;

                Console.WriteLine("Тип m: " + m.GetType());

                string s = m.ToString();
                Console.WriteLine("Моя версия .NET Framework: " + s);

                Version v = (Version)m.Clone();
                Console.WriteLine("Значение переменной v: " + v);
            }
        }
    }
}