using System;

namespace limitationsOfGeneralizations
{
    class Program
    {

        class Account
        {
            public int Id { get; private set; } // номер счета
            public int Sum { get; set; }
            public Account(int _id)
            {
                Id = _id;
            }
        }

        class Transaction<T> where T : Account
        {
            public T FromAccount { get; set; }  // с какого счета перевод
            public T ToAccount { get; set; }    // на какой счет перевод
            public int Sum { get; set; }        // сумма перевода

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

        // private static void Main(string[] args)
        // {
        //     Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
        //     Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

        //     Transact<Account<int>>(acc1, acc2, 900);

        //     Console.Read();
        // }

        // public static void Transact<T>(T acc1, T acc2, int sum) where T : Account<int>
        // {
        //     if (acc1.Sum > sum)
        //     {
        //         acc1.Sum -= sum;
        //         acc2.Sum += sum;
        //     }
        //     Console.WriteLine($"acc1: {acc1.Sum}   acc2: {acc2.Sum}");
        // }
    }
}