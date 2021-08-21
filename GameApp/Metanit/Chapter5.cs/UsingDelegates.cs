using System;

namespace UsingDelegates
{
    class Program
    {
        class Account
        {
            public delegate void AccountStateHandler(string message);
            AccountStateHandler _del;
            public void RegisterHandler(AccountStateHandler del)
            {
                _del = del;
            }

            int _sum;

            public Account(int sum)
            {
                _sum = sum;
            }

            public int CurrentSum
            {
                get { return _sum; }
            }

            public void Put(int sum)
            {
                _sum += sum;
            }

            public void Withdraw(int sum)
            {
                if (sum <= _sum)
                {
                    _sum -= sum;
                }
            }

            public void Withdraws(int sum)
            {
                if (sum <= _sum)
                {
                    _sum -= sum;

                    if (_del != null)
                    {
                        _del($"Сумма {sum} снята со счета");
                    }
                }
                else
                {
                    if (_del != null)
                    {
                        _del("Недостаточно денег на счете");
                    }
                }
            }

            static void Main(string[] args)
            {
                // создаем банковский счет
                Account account = new Account(200);
                // Добавляем в делегат ссылку на метод Show_Message
                // а сам делегат передается в качестве параметра метода RegisterHandler
                account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
                // Два раза подряд пытаемся снять деньги
                account.Withdraws(100);
                account.Withdraws(150);
                Console.ReadLine();
            }
            private static void Show_Message(String message)
            {
                Console.WriteLine(message);
            }
        }

        class Example2
        {
            delegate int IntOperation(int i, int j);

            class Program
            {
                // Организуем ряд методов
                static int Sum(int x, int y)
                {
                    return x + y;
                }

                static int Prz(int x, int y)
                {
                    return x * y;
                }

                static int Del(int x, int y)
                {
                    return x / y;
                }

                static void Main()
                {
                    // Сконструируем делегат
                    IntOperation op1 = new IntOperation(Sum);

                    int result = op1(5, 10);
                    Console.WriteLine("Сумма: " + result);

                    // Изменим ссылку на метод
                    op1 = new IntOperation(Prz);
                    result = op1(5, 10);
                    Console.WriteLine("Произведение: " + result);

                    Console.ReadLine();
                }
            }
        }
    }
}