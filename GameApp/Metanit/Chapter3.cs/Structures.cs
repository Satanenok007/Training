using System;
namespace Structures
{
    class Program
    {
        class Books
        {
            struct Book
            {
                public string name;
                public int yearOfRelease;

                public Book(string name, int yearOfRelease)
                {
                    this.name = name;
                    this.yearOfRelease = yearOfRelease;

                }

                public void InformationAboutTheBook()
                {
                    Console.WriteLine($"Name: {name}  Year of realease: {yearOfRelease}");
                }
            }

            class Program
            {
                static void MainStructures(string[] args)
                {
                    Book book1;
                    book1.name = "A street cat named Bob";
                    book1.yearOfRelease = 2013;
                    book1.InformationAboutTheBook();

                    Book book2 = new Book("Flowers for Algernon", 1959);
                    book2.InformationAboutTheBook();
                }
            }
        }
    }

    class Example2
    {
        class Movies
        {
            struct Films
            {
                public string name;
                public int yearOfRelease;
                public int time;

                public Films(string name, int yearOfRelease, int time)
                {
                    this.name = name;
                    this.yearOfRelease = yearOfRelease;
                    this.time = time;

                }

                public void InformationAboutTheFilms()
                {
                    Console.WriteLine($"Name: {name}  Year of realease: {yearOfRelease}, time: {time}");
                }
            }

            class Program
            {
                static void MainMoves(string[] args)
                {
                    Films f1;
                    f1.name = "The silence of the lambs";
                    f1.yearOfRelease = 1991;
                    f1.time = 144;
                    f1.InformationAboutTheFilms();

                    Films f2 = new Films("White captivity", 2006, 120);
                    f2.InformationAboutTheFilms();
                }
            }
        }
    }
}