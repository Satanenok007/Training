using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new { Name = "Maison", Age = 25 };
            Console.WriteLine(user1.Name);

            var user2 = new { Name = "Paiton", Age = 35 };
            var student = new { Name = "Dilara", Age = 19 };
            var manager = new { Name = "Jack", Age = 33, Company = "Microsoft" };

            Console.WriteLine(user2.GetType().Name);
            Console.WriteLine(student.GetType().Name);
            Console.WriteLine(manager.GetType().Name);
        }
    }

    class ProjectionInitializers
    {
        class User
        {
            public string Name { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                User user3 = new User { Name = "Mike" };
                int age = 25;
                var student = new { user3.Name, age };
                Console.WriteLine(student.Name);
                Console.WriteLine(student.age);
            }
        }
    }
}