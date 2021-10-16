using System;

namespace UsingDelegates
{
    class Account
    {
        int _sum;

        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;

        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del;
        }
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del;
        }

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
    }

    class Program
    {

        static void MainUsingDelegates(string[] args)
        {
            Account account = new Account(200);
            Account.AccountStateHandler colorDelegate = new Account.AccountStateHandler(Color_Message);


            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account.RegisterHandler(colorDelegate);

            account.Withdraw(100);
            account.Withdraw(150);

            account.UnregisterHandler(colorDelegate);
            account.Withdraw(50);

            Console.ReadLine();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
        private static void Color_Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}