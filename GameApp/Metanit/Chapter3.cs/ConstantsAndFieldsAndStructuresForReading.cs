using System;

namespace ConstantsAndFieldsAndStructuresForReading
{
    class Sum
    {
        public const int x = 10;
        public readonly int Y = 20;

        public Sum(int _y)
        {
            Y = _y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Sum.x + 10;
            Console.WriteLine(sum1);
            Sum sum2 = new Sum(15);
            Console.WriteLine(sum2.Y);
        }
    }

    class Example2
    {
        class Library
        {
            public const int youCanTakeBooksAtATime = 5;
            public readonly int books = 10000;

            public Library(int _books)
            {
                books = _books;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int p1 = Library.youCanTakeBooksAtATime + 10;
                Console.WriteLine(p1);
                Library p2 = new Library(15);
                Console.WriteLine(p2.books);
            }
        }

    }
}