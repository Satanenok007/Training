using System;

namespace LimitationsOfGeneralization
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
            Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

            Transaction<Account<int>> transaction1 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 6900
            };
            transaction1.Execute();

            Console.Read();
        }
    }
    class Account<T>
    {
        public T Id { get; private set; }
        public int Sum { get; set; }
        public Account(T _id)
        {
            Id = _id;
        }
    }
    class Transaction<T> where T : Account<int>
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }

    class LimitationsOfMethods
    {
        private static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
            Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

            Transact<Account<int>>(acc1, acc2, 900);

            Console.Read();
        }

        public static void Transact<T>(T acc1, T acc2, int sum) where T : Account<int>
        {
            if (acc1.Sum > sum)
            {
                acc1.Sum -= sum;
                acc2.Sum += sum;
            }
            Console.WriteLine($"acc1: {acc1.Sum}   acc2: {acc2.Sum}");
        }
    }
}