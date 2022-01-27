using System;
using System.Collections;

namespace IEnumerableAndIEnumeratorInterfaces
{
    class C1
    {
        static void F1(string[] args)
        {
            string[] obj1 = { "Cat", "Dog", "Fox" };
            IEnumerator obj1Enumerator = obj1.GetEnumerator();
            while (obj1Enumerator.MoveNext())
            {
                string item = (string)obj1Enumerator.Current;
                Console.WriteLine(item);
            }
            obj1Enumerator.Reset();

            Numb numb1 = new Numb();
            foreach (var num in numb1)
            {
                Console.WriteLine(num);
            }

            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
    // public interface IEnumerable
    // {
    //     IEnumerator GetEnumerator();
    // }

    // public interface IEnumerator
    // {
    //     bool MoveNext();
    //     object Current { get; }
    //     void Reset();
    // }

    class Numb
    {
        string[] numb = { "1", "2", "3", "4", "5", "6", "7", "8" };
        public IEnumerator GetEnumerator() => numb.GetEnumerator();
    }

    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days) => this.days = days;
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                {
                    throw new ArgumentException();
                }
                return days[position];
            }
        }
        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => position = -1;
    }
    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator() => new WeekEnumerator(days);
    }
}