using System;
// using Person = HelloApp.User;
// using Printer = System.Console;
// public class Programs
// {
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
    // static void Main()
    // {
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
    // }

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
// }
// namespace HelloApp
// {
//     class Test
//     {
//         static void Main(string[] args)
//         {
//             Person person = new Person();
//             person.name = "Tom";
//             Printer.WriteLine(person.name);
//             Printer.Read();
//         }
//     }

//     class User
//     {
//         public string name;
//     }
// }



// public class State
// {
//     // все равно, что private int defaultVar;
//     int defaultVar;
//     // поле доступно только из текущего класса
//     private int privateVar;
//     // доступно из текущего класса и производных классов, которые определены в этом же проекте
//     protected private int protectedPrivateVar;
//     // доступно из текущего класса и производных классов
//     protected int protectedVar;
//     // доступно в любом месте текущего проекта
//     internal int internalVar;
//     // доступно в любом месте текущего проекта и из классов-наследников в других проектах
//     protected internal int protectedInternalVar;
//     // доступно в любом месте программы, а также для других программ и сборок
//     public int publicVar;

//     // по умолчанию имеет модификатор private
//     void defaultMethod() => Console.WriteLine($"defaultVar = {defaultVar}");

//     // метод доступен только из текущего класса
//     private void privateMethod() => Console.WriteLine($"privateVar = {privateVar}");

//     // доступен из текущего класса и производных классов, которые определены в этом же проекте
//     protected private void protectedPrivateMethod() => Console.WriteLine($"protectedPrivateVar = {protectedPrivateVar}");

//     // доступен из текущего класса и производных классов
//     protected void protectedMethod() => Console.WriteLine($"protectedVar = {protectedVar}");

//     // доступен в любом месте текущего проекта
//     internal void internalMethod() => Console.WriteLine($"internalVar = {internalVar}");

//     // доступен в любом месте текущего проекта и из классов-наследников в других проектах
//     protected internal void protectedInternalMethod() => Console.WriteLine($"protectedInternalVar = {protectedInternalVar}");

//     // доступен в любом месте программы, а также для других программ и сборок
//     public void publicMethod() => Console.WriteLine($"publicVar = {publicVar}");
// }

// class Program
// {

//     static void Main(string[] args)
//     {
//         State state1 = new State();

//         // присвоить значение переменной defaultVar у нас не получится,
//         // так как она имеет модификатор private и класс Program ее не видит
//         // И данную строку среда подчеркнет как неправильную
//         // state1.defaultVar = 5; //Ошибка, получить доступ нельзя

//         // то же самое относится и к переменной privateVar
//         // state1.privateVar = 5; // Ошибка, получить доступ нельзя

//         // присвоить значение переменной protectedPrivateVar не получится,
//         // так как класс Program не является классом-наследником класса State
//         // state1.protectedPrivateVar = 5; // Ошибка, получить доступ нельзя

//         // присвоить значение переменной protectedVar тоже не получится,
//         // так как класс Program не является классом-наследником класса State
//         // state1.protectedVar = 5; // Ошибка, получить доступ нельзя

//         // переменная internalVar с модификатором internal доступна из любого места текущего проекта
//         // поэтому спокойно присваиваем ей значение
//         state1.internalVar = 5;

//         // переменная protectedInternalVar так же доступна из любого места текущего проекта
//         state1.protectedInternalVar = 5;

//         // переменная publicVar общедоступна
//         state1.publicVar = 5;
//     }
// }



// Person p = new Person();
 
// // Устанавливаем свойство - срабатывает блок Set
// // значение "Tom" и есть передаваемое в свойство value
// p.Name = "Tom";
 
// // Получаем значение свойства и присваиваем его переменной - срабатывает блок Get
// string personName = p.Name; 

// class Person
// {
//     private string name;
 
//     public string Name
//     {
//         get
//         {
//             return name;
//         }
 
//         set
//         {
//             name = value;
//         }
//     }
// }


// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
         
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
// }


// class Person
// {
//     public string Name { get; set; } = "Tom";
//     public int Age { get; set; } = 23;
// }
     
// class Program
// {
//     static void Main(string[] args)
//     {
//         Person person = new Person();
//         Console.WriteLine(person.Name); // Tom
//         Console.WriteLine(person.Age);  // 23
         
//         Console.Read();
//     }
// }

// class Person
// {
//     public string Name { private set; get;}
//     public Person(string n)
//     {
//         Name = n;
//     }
// }


// class Person
// {
//     private string name;
     
//     // эквивалентно public string Name { get { return name; } }
//     public string Name => name;
// }