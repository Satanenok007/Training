using System;

namespace TestEvents
{
    class C1
    {
        static void F1()
        {
            SumNumb obj1 = new SumNumb(1000);
            obj1.Put(10);
            Console.WriteLine($"{obj1.Sum}");
            obj1.Take(50);
            Console.WriteLine($"{obj1.Sum}");
            obj1.Take(200);
            Console.WriteLine(100);

            SumNumb obj2 = new SumNumb(2000);
            obj2.Notify += F2;
            obj2.Put(20);
            Console.WriteLine(obj2.Sum);
            obj2.Take(1000);
            Console.WriteLine(obj2.Sum);
            obj2.Notify -= F2;
            void F2(string mess) => Console.WriteLine(mess);
        }
    }

    class SumNumb
    {
        public delegate void delegate1(string mess);
        delegate1? notify;
        public event delegate1 Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"{value.Method.Name}");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"удалено: {value.Method.Name}");
            }
        }
        public int Sum { get; private set; }
        public SumNumb(int sum) => Sum = sum;
        public void Put(int sum)
        {
            Sum += sum;
            Console.WriteLine($"добавлено число: {sum}");
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Console.WriteLine($"удалено число: {sum}");
            }
            else
            {
                notify?.Invoke($"удаляемое число больше имеющегося: {Sum}");
            }
        }
    }
}