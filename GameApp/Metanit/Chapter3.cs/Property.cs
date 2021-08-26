using System;

namespace Property
{
    class Program
    {
        class Person
        {
            public string name;
            internal int age;

            public int Age
            {
                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Возраст должен быть больше 17-ти");
                    }
                    else
                    {
                        age = value;
                    }
                }
                get
                {
                    return age;
                }
            }
            class BuyingABooks
            {
                public void Main(string[] args)
                {
                    Person p1 = new Person();
                    p1.name = "Kate";
                    p1.age = 17;
                }
            }
        }

        class AutomaticProperties
        {
            class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }

                public Person(string name, int age)
                {
                    Name = name;
                    Age = age;
                }
            }
        }

        class AbbreviatedProperties
        {
            class Person
            {
                private string name;
                public string Name => name; // public string Name { get { return name; } }
            }
        }
    }
}