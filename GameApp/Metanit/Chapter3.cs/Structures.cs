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
                static void Main(string[] args)
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
}