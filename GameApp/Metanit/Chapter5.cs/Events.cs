using System;

namespace Events
{
    class Program
    {
        class BankAccount
        {
            class Account
            {
                public Account(int sum)
                {
                    Sum = sum;
                }
                // сумма на счете
                public int Sum { get; private set; }
                // добавление средств на счет
                public void Put(int sum)
                {
                    Sum += sum;
                }
                // списание средств со счета
                public void Take(int sum)
                {
                    if (Sum >= sum)
                    {
                        Sum -= sum;
                    }
                }
            }

            static void Main(string[] args)
            {
                Account acc = new Account(100);
                acc.Put(20);    // добавляем на счет 20
                Console.WriteLine($"Сумма на счете: {acc.Sum}");
                acc.Take(70);   // пытаемся снять со счета 70
                Console.WriteLine($"Сумма на счете: {acc.Sum}");
                acc.Take(180);  // пытаемся снять со счета 180
                Console.WriteLine($"Сумма на счете: {acc.Sum}");
            }
        }


        class DefiningAndInvokingEvents
        {
            class Account
            {
                public delegate void AccountHandler(string message);
                public event AccountHandler Notify;              // 1.Определение события
                public Account(int sum)
                {
                    Sum = sum;
                }
                public int Sum { get; private set; }
                public void Put(int sum)
                {
                    Sum += sum;
                    Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
                }
                public void Take(int sum)
                {
                    if (Sum >= sum)
                    {
                        Sum -= sum;
                        Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
                    }
                    else
                    {
                        Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
                    }
                }
            }

            static void Main(string[] args)
            {
                Account acc = new Account(100);
                acc.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
                acc.Notify += DisplayRedMessage;    // добавляем обработчик DisplayMessage
                acc.Put(20);    // добавляем на счет 20
                acc.Notify -= DisplayRedMessage;     // удаляем обработчик DisplayRedMessage
                acc.Put(20);    // добавляем на счет 20
                Console.Read();
            }

            private static void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }

            private static void DisplayRedMessage(String message)
            {
                // Устанавливаем красный цвет символов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                // Сбрасываем настройки цвета
                Console.ResetColor();
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
            }
        }

        class DataClassOfTheAccountEventArgsEvent
        {

            class AccountEventArgs
            {
                // Сообщение
                public string Message { get; }
                // Сумма, на которую изменился счет
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

            static void Main(string[] args)
            {
                Account acc = new Account(100);
                acc.Notify += DisplayMessage;
                acc.Put(20);
                acc.Take(70);
                acc.Take(150);
                Console.Read();
            }
            private static void DisplayMessage(object sender, AccountEventArgs e)
            {
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
            }
        }
    }
}