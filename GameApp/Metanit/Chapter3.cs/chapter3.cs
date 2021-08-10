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

// class Calculator
// {
//     public void Add(int a, int b)
//     {
//         int result = a + b;
//         Console.WriteLine($"Result is {result}");
//     }
//     public void Add(int a, int b, int c)
//     {
//         int result = a + b + c;
//         Console.WriteLine($"Result is {result}");
//     }
//     public int Add(int a, int b, int c, int d)
//     {
//         int result = a + b + c + d;
//         Console.WriteLine($"Result is {result}");
//         return result;
//     }
//     public void Add(double a, double b)
//     {
//         double result = a + b;
//         Console.WriteLine($"Result is {result}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculator calc = new Calculator();
//         calc.Add(1, 2); // 3
//         calc.Add(1, 2, 3); // 6
//         calc.Add(1, 2, 3, 4); // 10
//         calc.Add(1.4, 2.5); // 3.9

//         Console.ReadKey();
//     }
// }


// class Account
// {
//     public static decimal bonus = 100;
//     public decimal totalSum;
//     public Account(decimal sum)
//     {
//         totalSum = sum + bonus; 
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(Account.bonus);      // 100
//         Account.bonus += 200;

//         Account account1 = new Account(150);
//         Console.WriteLine(account1.totalSum);   // 450


//         Account account2 = new Account(1000);
//         Console.WriteLine(account2.totalSum);   // 1300

//         Console.ReadKey();
//     }
// }

// Console.WriteLine(Account.bonus);
// Account.bonus += 200;


// class Account
// {
//     public Account(decimal sum, decimal rate)
//     {
//         if (sum < MinSum) throw new Exception("Недопустимая сумма!");
//         Sum = sum; Rate = rate;
//     }
//     private static decimal minSum = 100; // минимальная допустимая сумма для всех счетов
//     public static decimal MinSum
//     {
//         get { return minSum; }
//         set { if (value > 0) minSum = value; }
//     }

//     public decimal Sum { get; private set; }    // сумма на счете
//     public decimal Rate { get; private set; }   // процентная ставка

// 
//     public static decimal GetSum(decimal sum, decimal rate, int period)
//     {
//         decimal result = sum;
//         for (int i = 1; i <= period; i++)
//             result = result + result * rate / 100;
//         return result;
//     }

// }

// Account.MinSum = 560;
// decimal result = Account.GetSum(1000, 10, 5);


// class User
// {
//     static User()
//     {
//         Console.WriteLine("Создан первый пользователь");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         User user1 = new User(); // здесь сработает статический конструктор
//         User user2 = new User();

//         Console.Read();
//     }
// }

// static class Account
// {
//     private static decimal minSum = 100;
//     public static decimal MinSum
//     {
//         get { return minSum; }
//         set { if (value > 0) minSum = value; }
//     }

//     public static decimal GetSum(decimal sum, decimal rate, int period)
//     {
//         decimal result = sum;
//         for (int i = 1; i <= period; i++)
//             result = result + result * rate / 100;
//         return result;
//     }
// }



//Константы
// const double PI = 3.14;
// const double E = 2.71;

// class MathLib
// {
//     public const double PI = 3.141;
//     public const double E = 2.81;
//     // public const double K;      // Ошибка, константа не инициализирована
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // MathLib.E = 3.8; // Ошибка, значение константы нельзя изменить
//         Console.WriteLine(MathLib.PI);
//     }
// }


// class  MathLibs
// {
//     public readonly double K = 23;  // можно так инициализировать

//     public  MathLibs
// (double _k)
//     {
//         K = _k; // поле для чтения может быть инициализировано или изменено в конструкторе после компиляции
//     }
//     public void ChangeField()
//     {
//         // так нельзя
//         //K = 34;
//     }
// }

// class Programs
// {
//     static void Main(string[] args)
//     {
//          MathLibs
//          mathLib = new  MathLibs
//         (3.8);
//         Console.WriteLine(mathLib.K); // 3.8

//         //mathLib.K = 7.6; // поле для чтения нельзя установить вне своего класса
//         Console.ReadLine();

//     }
// }

// readonly struct User
// {
//     public readonly string name;
//     public User(string name)
//     {
//         this.name = name;
//     }
// }

// readonly struct User
// {
//     public readonly string Name { get; } // указывать readonly необязательно
//     public int Age { get; } // свойство только для чтения
//     public User(string name, int age)
//     {
//         this.Name = name;
//         this.Age = age;
//     }
// }



//Перегрузка операторов

// Counter c1 = new Counter { Value = 23 };
// Counter c2 = new Counter { Value = 45 };

// static void Main(string[] args)
// {
//     Counter c1 = new Counter { Value = 23 };
//     Counter c2 = new Counter { Value = 45 };
//     bool result = c1 > c2;
//     Console.WriteLine(result); // false

//     Counter c3 = c1 + c2;
//     Console.WriteLine(c3.Value);  // 23 + 45 = 68
// }
// bool result = c1 > c2;
// Counter c3 = c1 + c2;
// class Counter
// {
//     public int Value { get; set; }

// }

// class Counter
// {
//     public int Value { get; set; }

//     public static Counter operator +(Counter c1, Counter c2)
//     {
//         return new Counter { Value = c1.Value + c2.Value };
//     }
//     public static bool operator >(Counter c1, Counter c2)
//     {
//         return c1.Value > c2.Value;
//     }
//     public static bool operator <(Counter c1, Counter c2)
//     {
//         return c1.Value < c2.Value;
//     }
// }

// public static Counter operator +(Counter c1, Counter c2)
// {
//     return new Counter { Value = c1.Value + c2.Value };
// }


//Значение null

// object o = null;
// string s = null;

// object x = null;
// object y = x ?? 100;  // равно 100, так как x равен null

// object z = 200;
// object t = z ?? 44; // равно 200, так как z не равен null


// class User
// {
//     public Phone Phone { get; set; }
// }

// class Phone
// {
//     public Company Company { get; set; }
// }

// class Company
// {
//     public string Name { get; set; }
// }

// User user = new User();
// Console.WriteLine(user.Phone.Company.Name);


// if(user!=null && user.Phone!=null && user.Phone.Company!=null)
// {
//     string companyName = user.Phone.Company.Name;
//     Console.WriteLine(companyName);
// }