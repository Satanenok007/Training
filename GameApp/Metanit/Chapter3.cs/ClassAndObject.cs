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
}

