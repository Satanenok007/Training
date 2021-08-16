using System;

namespace CreatingExceptionClasses
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Tom", Age = 17 };
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
                    throw new Exception("Лицам до 18 регистрация запрещена");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class PersonException : Exception
    {
        public PersonException(string message)
            : base(message)
        { }
    }

    class ExceptionHandlingInTheMainProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Person p = new Person { Age = 17 };
                }
                catch (PersonException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                Console.Read();
            }
        }
        class Person
        {
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 18)
                    {
                        throw new PersonException("Лицам до 18 регистрация запрещена");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
        }
    }

    // class GettingAProperty
    // {
    //     class Person
    //     {
    //         private int age;
    //         public int Age
    //         {
    //             get { return age; }
    //             set
    //             {
    //                 if (value < 18)
    //                 {
    //                     throw new PersonException("Лицам до 18 регистрация запрещена", value);
    //                 }
    //                 else
    //                 {
    //                     age = value;
    //                 }
    //             }
    //         }
    //     }
    //     class Program
    //     {
    //         static void Main(string[] args)
    //         {
    //             try
    //             {
    //                 Person p = new Person { Age = 13 };
    //             }
    //             catch (PersonException ex)
    //             {
    //                 Console.WriteLine($"Ошибка: {ex.Message}");
    //                 Console.WriteLine($"Некорректное значение: {ex.Value}");
    //             }
    //         }
    //     }
    // }
}