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
}