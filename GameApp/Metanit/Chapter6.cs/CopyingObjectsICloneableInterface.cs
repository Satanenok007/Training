using System;

namespace CopyingObjectsICloneableInterface
{
    class Program
    {
        static void MainCopyingObjectsICloneableInterface(string[] args)
        {
            Person p1 = new Person { Name = "Naiton", Age = 25 };
            Person p2 = p1;
            p2.Name = "Sofia";
            Console.WriteLine(p1.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Example2
    {
        class Person : ICloneable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public object Clone()
            {
                return new Person { Name = this.Name, Age = this.Age };
            }
        }

        class Program
        {
            static void MainExample2Class(string[] args)
            {
                Person p1 = new Person { Name = "Joch", Age = 17 };
                Person p2 = (Person)p1.Clone();
                p2.Name = "Maison";
                Console.WriteLine(p1.Name);
            }
        }
    }

    class MethodMemberwiseClone
    {
        class Person : ICloneable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }
        
        class SurfaceCopying
        {
            class Person : ICloneable
            {
                public string Name { get; set; }
                public int Age { get; set; }
                public Company Work { get; set; }

                public object Clone()
                {
                    return this.MemberwiseClone();
                }
            }

            class Company
            {
                public string Name { get; set; }
            }

            class Program
            {
                static void MainMethodMemberwiseClone(string[] args)
                {
                    Person p1 = new Person { Name = "Mike", Age = 31, Work = new Company { Name = "Microsoft" } };
                    Person p2 = (Person)p1.Clone();
                    p2.Work.Name = "RedStrim";
                    p2.Name = "Inessa";
                    Console.WriteLine(p1.Name);
                    Console.WriteLine(p1.Work.Name);
                }
            }
        }

        class DeepCopying
        {
            class Person : ICloneable
            {
                public string Name { get; set; }
                public int Age { get; set; }
                public Company Work { get; set; }

                public object Clone()
                {
                    Company company = new Company { Name = this.Work.Name };
                    return new Person
                    {
                        Name = this.Name,
                        Age = this.Age,
                        Work = company
                    };
                }
            }

            class Company
            {
                public string Name { get; set; }
            }
        }
    }
}