using System;

namespace Generalizations
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account<int> account1 = new Account<int> { Sum = 5000 };
            Account<string> account2 = new Account<string> { Sum = 4000 };
            account1.Id = 2;
            account2.Id = "4356";
            int id1 = account1.Id;
            string id2 = account2.Id;
            Console.WriteLine(id1);
            Console.WriteLine(id2);


            Account<int> acc1 = new Account<int> { Id = 1857, Sum = 4500 };
            Account<int> acc2 = new Account<int> { Id = 3453, Sum = 5000 };

            Transaction<Account<int>, string> transaction1 = new Transaction<Account<int>, string>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Code = "45478758",
                Sum = 900
            };
        }
        class Account<T>
        {
            public T Id { get; set; }

            // T id = default(T); // значение по умолчвнию
            public int Sum { get; set; }
        }

        class Transaction<U, V>
        {
            public U FromAccount { get; set; }  // с какого счета перевод
            public U ToAccount { get; set; }    // на какой счет перевод
            public V Code { get; set; }         // код операции
            public int Sum { get; set; }        // сумма перевода
        }
    }
}