using System;

namespace StaticMembersAndTheStaticModifier
{
    class Program
    {
        class Account
        {
            public static int book;
            public decimal allBooks;

            static Account()
            {
                book = 20;
            }

            public int LimitBook
            {
                set
                {
                    if (value < 1000)
                    {
                        Console.WriteLine("Привышен линит читаемых книг для 1-го пользователя");
                    }
                    else
                    {
                        book = value;
                    }
                }
                get
                {
                    return book;
                }
            }

            public Account(decimal book)
            {
                allBooks = book + Account.book;
            }
        }
        class Programs
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Account.book);
                Account.book += 10;

                Account account1 = new Account(15);
                Console.WriteLine(account1.allBooks);   // 45


                Account account2 = new Account(30);
                Console.WriteLine(account2.allBooks);   // 75

            }
        }
    }
    class Example2
    {
        class MyCircle
        {
            public static double SqrCircle(int radius)
            {
                return Math.PI * radius * radius;
            }
            public static double LongCircle(int radius)
            {
                return 2 * Math.PI * radius;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int r = 10;
                Console.WriteLine("Площадь круга радиусом {0} = {1:#.##}", r, MyCircle.SqrCircle(r));
                Console.WriteLine("Длина круга равна {0:#.##}", MyCircle.LongCircle(r));
            }
        }
    }
    class Example3
    {
        class MyClass
        {
            public static int a;
            public static int b;

            static MyClass()
            {
                a = 12;
            }
            public MyClass()
            {
                b = 12;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Доступ к экземпляру класса a: " + MyClass.a);
                Console.WriteLine("Доступ к экземпляру класса b: " + MyClass.b);
            }
        }
    }
}