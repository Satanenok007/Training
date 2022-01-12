using System;

namespace Events
{
    class C1
    {
        static void F1()
        {
            C2 obj1 = new C2(100);
            obj1.Notify += Message;
            obj1.Notify += RedMessage;
            obj1.F2(20);
            obj1.Notify -= RedMessage;
            obj1.F2(50);

            void Message(string message) => Console.WriteLine(message);
            void RedMessage(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
    class C2
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public C2(int sum) => Sum = sum;
        public int Sum { get; private set; }

        public void F2(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");
        }
        public void F3(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
}