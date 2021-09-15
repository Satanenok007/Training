using System;

namespace Events
{
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }

        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }
    class Account
    {
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public event AccountHandler Notify;
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); ;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(20);
            acc.Take(70);
            acc.Take(150);
            Console.Read();
            static void DisplayMessage(object sender, AccountEventArgs e)
            {
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
            }
        }
    }
}

class ManagingHandlers
{
    class Account
    {
        public delegate void AccountHandler(string message);
        private event AccountHandler _notify;
        public event AccountHandler Notify
        {
            add
            {
                _notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove
            {
                _notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            _notify?.Invoke($"На счет поступило: {sum}");
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                _notify?.Invoke($"Со счета снято: {sum}");
            }
            else
            {
                _notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(20);
            acc.Notify -= DisplayMessage;
            acc.Put(20);
        }
        private static void DisplayMessage(string message) => Console.WriteLine(message);
    }

    class Event
    {
        delegate void UI();
        class MyEvent
        {
            public event UI UserEvent;
            public void OnUserEvent()
            {
                UserEvent();
            }
        }

        class UserInfo
        {
            string uiName, uiFamily;
            int uiAge;
            public UserInfo(string Name, string Family, int Age)
            {
                this.uiName = Name;
                this.uiFamily = Family;
                this.uiAge = Age;
            }

            public string Name { set { uiName = value; } get { return uiName; } }
            public string Family { set { uiFamily = value; } get { return uiFamily; } }
            public int Age { set { uiAge = value; } get { return uiAge; } }

            public void UserInfoHandler()
            {
                Console.WriteLine("Событие вызвано!\n");
                Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}", Name, Family, Age);
            }

            class Program
            {
                static void Main()
                {
                    MyEvent evt = new MyEvent();
                    UserInfo user1 = new UserInfo(Name: "Sofia", Family: "Kmita", Age: 16);
                    evt.UserEvent += user1.UserInfoHandler;
                    evt.OnUserEvent();
                }
            }
        }
    }
}