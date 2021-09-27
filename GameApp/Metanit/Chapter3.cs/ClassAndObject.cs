using System;
namespace ClassAndObject
{

    enum Color
    {
        Green,
        Red,
        Blue,
        Yellow,
        Orange
    }
    class Point
    {
        public int coordinateX;
        public int coordinateY;
        public Color color;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            p.coordinateX = 4;
            p.coordinateY = 2;
            p.color = Color.Red;

            Console.WriteLine($"X: {p.coordinateX} | Y: {p.coordinateY} | Color: {p.color}");
        }
    }

    class Example2
    {
        class Movies
        {
            public string name;
            public int yearOfRelease;
            public string genre;
            public string producer;
            public string country;


            public void Print()
            {
                Console.WriteLine("Информация о фильме: ");
                Console.WriteLine($"Название: {name}");
                Console.WriteLine($"lastName: {genre}");
                Console.WriteLine($"firstName: {yearOfRelease}");
                Console.WriteLine($"middelName: {producer}");
                Console.WriteLine($"age: {country}");
            }
        }

        class Program
        {
            static Movies GetStudent()
            {
                Movies film = new Movies();
                film.name = "Perfect Patient";
                film.yearOfRelease = 2018;
                film.genre = "thriller";
                film.producer = "Helena Danielsson";
                film.country = "Switzerland";
                return film;
            }


            static void Main(string[] args)
            {
                var film1 = GetStudent();
                film1.Print();
            }

        }
    }
    class Exeption3
    {

        class Person
        {
            public string name;
            public string surname;
            public int age;
            public string placeOfResidence;
            public string placeOfWork;
            public string position;
            public void Print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Surname: {surname}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Plase of residence: {placeOfResidence}");
                Console.WriteLine($"Place of work: {placeOfWork}");
                Console.WriteLine($"Position: {position}");
            }
        }
        class Program
        {
            static Person GetPerson()
            {
                Person p1 = new Person();
                p1.name = "Frank";
                p1.surname = "Pitt";
                p1.age = 31;
                p1.placeOfResidence = "Mexico";
                p1.placeOfWork = "Dr.Vet";
                p1.position = "doctor";
                return p1;
            }

            static void Main(string[] args)
            {
                var person1 = GetPerson();
                person1.Print();
            }

        }
    }
}

