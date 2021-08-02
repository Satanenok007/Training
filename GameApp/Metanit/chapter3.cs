using System;
public class Programs
{
    // class Person
    // {
    //     public string name;
    //     public int age;

    //     public Person() { name = "Unknown"; age = 30; }
    //     public Person(string n) { name = n; age = 18; }
    //     public Person(string n, int a) { name = n; age = a; }
    //     public void GetInfo()
    //     {
    //         Console.WriteLine($"Name: {name}  Age: {age}");
    //     }
    // }
    // class Person
    // {
    //     public string name;
    //     public int age;

    //     public Person() : this("Unknown")
    //     {
    //     }
    //     public Person(string name) : this(name, 18)
    //     {
    //     }
    //     public Person(string name, int age)
    //     {
    //         this.name = name;
    //         this.age = age;
    //     }
    //     public void GetInfo()
    //     {
    //         Console.WriteLine($"Name: {name}  Age: {age}");
    //     }
    // public static void Main()
    // {
    //     Person nastya = new();
    //     Person joch = new("Joch");
    //     Person kate = new("Kate", 23);

    //     nastya.GetInfo();
    //     joch.GetInfo();
    //     kate.GetInfo();
    // }
    // }

    struct User
    {
        public string name;
        public int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }

    static void Main(string[] args)
    {
        User kate = new User("Kate", 19);
        kate.DisplayInfo();

        User nastya = new User("Nastya", 17);
        nastya.DisplayInfo();
    }
}