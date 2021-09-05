using System;

namespace CreatingExceptionClasses
{
    class Book
    {
        static void Main(string[] args)
        {
            try
            {
                Person p1 = new Person { Name = "Sofia", Age = 16 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
    }
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception($"Лицам до 18 регистрация запрещена {value}");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class PersonException : ArgumentException
    {
        public PersonException(string message)
            : base(message)
        { }
    }

    class PersonExceptions : ArgumentException
    {
        public int Value { get; }
        public PersonExceptions(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Tom", Age = 13 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
    }
}