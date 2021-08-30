using System;

namespace VirtualMethodsAndProperties
{
    class People
    {
        public string Name { get; set; }
        public People(string name)
        {
            Name = name;
        }
        public virtual void Info()
        {
            Console.WriteLine(Name);
        }
    }

    class Student : People
    {
        public int Group { get; set; }
        public Student(string name, int group)
            : base(name)
        {
            Group = group;
        }

        public override void Info()
        {
            Console.WriteLine($"{Name} работает в {Group}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People("Nastya");
            p1.Info(); // вызов метода Info из класса People

            Student p2 = new Student("Sofia", 586);
            p2.Info(); // вызов метода Info из класса Student
        }
    }

    class RedefiningProperties
    {
        class Library
        {
            public virtual decimal Books { get; set; }
        }
        class MaxBooks : Library
        {
            private decimal book;
            public override decimal Books
            {
                get
                {
                    return book;
                }
                set
                {
                    if (value > 100)
                    {
                        book = value;
                    }
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                MaxBooks book = new MaxBooks { Books = 20 };
                book.Books = 47;
                Console.WriteLine(book.Books);
            }
        }
    }

    class TheBaseKeyword
    {
        class Employee : People
        {
            public string Company { get; set; }

            public Employee(string name, string company)
                    : base(name)
            {
                Company = company;
            }

            public override void Info()
            {
                base.Info();
                Console.WriteLine($"работает в {Company}");
            }
        }
    }

    class ProhibitionOfRedefiningMethods
    {
        class User : People
        {
            public string Email { get; set; }

            public User(string name, string email)
                        : base(name)
            {
                Email = email;
            }

            public override sealed void Info()
            {
                Console.WriteLine($"{Name}, на ваш email: {Email} было выслано письмо");
            }
        }
    }
}