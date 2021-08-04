using System;
using Person = HelloApp.User;
using Printer = System.Console;
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

    //Структуры
    // struct User
    // {
    //     public string name;
    //     public int age;
    //     public User(string name, int age)
    //     {
    //         this.name = name;
    //         this.age = age;
    //     }
    //     public void DisplayInfo()
    //     {
    //         Console.WriteLine($"Name: {name}  Age: {age}");
    //     }
    // }

    // static void Main(string[] args)
    // {
    //     User kate = new User("Kate", 19);
    //     kate.DisplayInfo();

    //     User nastya = new User("Nastya", 17);
    //     nastya.DisplayInfo();
    // }

    //Типы значений и ссылочные типы
    static void Main()
    {
        // Calculate(5);


        // State state1 = new State();
        // state1.country = new Country();
        // Country country1 = new Country();

        // State state1 = new State(); // Структура State
        // State state2 = new State();
        // state2.x = 1;
        // state2.y = 2;
        // state1 = state2;
        // state2.x = 5; // state1.x = 1 по-прежнему
        // Console.WriteLine(state1.x); // 1
        // Console.WriteLine(state2.x); // 5

        // Country country1 = new Country(); // Класс Country
        // Country country2 = new Country();
        // country2.x = 1;
        // country2.y = 4;
        // country1 = country2;
        // country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
        //                 // указывают на один объект в куче
        // Console.WriteLine(country1.x);
        // Console.WriteLine(country2.x);


        // State state1 = new State(); 
        // State state2 = new State();

        // state2.country = new Country();
        // state2.country.x = 5;
        // state1 = state2;
        // state2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
        //                     // указывают на один объект в хипе
        // Console.WriteLine(state1.country.x); // 8
        // Console.WriteLine(state2.country.x); // 8


        // Person p = new Person { name = "Tom", age = 23 };
        // ChangePerson(ref p);

        // Console.WriteLine(p.name); // Alice
        // Console.WriteLine(p.age); // 23
    }

    // static void Calculate(int t)
    // {
    //     object x = 6;
    //     int y = 7;
    //     int z = y + t;
    //     Console.WriteLine(z);
    // }

    // struct State
    // {
    //     public int x;
    //     public int y;
    //     public Country country;
    // }
    // class Country
    // {
    //     public int x;
    //     public int y;
    // }


    // static void ChangePerson(ref Person person)
    // {
    //     // сработает
    //     person.name = "Alice";
    //     // тоже сработает, поскольку есть ключевое слово ref
    //     person = new Person { name = "Bill", age = 45 };
    //     //сработает только в рамках данного метода
    //     person = new Person {name = "Kate", age = 28};
    // }
    // class Person
    // {
    //     public string name;
    //     public int age;
    // }
}
namespace HelloApp
{
    class Test
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Tom";
            Printer.WriteLine(person.name);
            Printer.Read();
        }
    }

    class User
    {
        public string name;
    }
}

