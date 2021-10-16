using System;

namespace Generalizations
{
    class User<T>
    {
        public static T session;
        public T Id = default(T);
        public string Name { get; set; }
    }

    class Program
    {
        static void MainGeneralizations(string[] args)
        {
            User<int> user1 = new User<int> { Name = "Gera" };
            User<int>.session = 4657;
            User<string> user2 = new User<string> { Name = "Alise" };
            User<string>.session = "3827";

            user1.Id = 12345;
            user2.Id = "9863";
            int id1 = user1.Id;
            string id2 = user2.Id;

            Console.WriteLine(id1);
            Console.WriteLine(id2);
            Console.WriteLine(User<int>.session);
            Console.WriteLine(User<string>.session);
        }
    }

    class UsingSeveralUniversalParameters
    {
        class Transaction<U, V>
        {
            public U FromAccount { get; set; }  // с какого счета перевод
            public U ToAccount { get; set; }    // на какой счет перевод
            public V Code { get; set; }         // код операции
            public int Sum { get; set; }        // сумма перевода
        }

        class Program
        {
            static void MainGeneralization(string[] args)
            {
                User<int> acc1 = new User<int> { Id = 1857, Name = "Billi" };
                User<int> acc2 = new User<int> { Id = 3453, Name = "Deniel" };

                Transaction<User<int>, string> transaction1 = new Transaction<User<int>, string>
                {
                    FromAccount = acc1,
                    ToAccount = acc2,
                    Code = "45478758",
                    Sum = 900
                };
            }
        }
    }
}

