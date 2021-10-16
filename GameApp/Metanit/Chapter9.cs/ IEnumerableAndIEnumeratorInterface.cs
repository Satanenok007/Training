using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableAndIEnumeratorInterface
{
    class Program
    {
        static void MainIEnumerableAndIEnumeratorInterfaces(string[] args)
        {
            int[] numbers = { 0, 2, 4, 6, 8, 10 };

            IEnumerator ie = numbers.GetEnumerator();
            while (ie.MoveNext())
            {
                int item = (int)ie.Current;
                Console.WriteLine(item);
            }
            ie.Reset();
        }
    }

    class Realise
    {
        class Week : IEnumerable
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };

            public IEnumerator GetEnumerator()
            {
                return days.GetEnumerator();
            }
        }
        class Program
        {
            static void MainRealise(string[] args)
            {
                Week week = new Week();
                foreach (var day in week)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }

    class RealiseIEnumerator
    {
        class WeekEnumerator : IEnumerator
        {
            string[] days;
            int position = -1;
            public WeekEnumerator(string[] days)
            {
                this.days = days;
            }
            public object Current
            {
                get
                {
                    if (position == -1 || position >= days.Length)
                    {
                        throw new InvalidOperationException();
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

            public void Reset()
            {
                position = -1;
            }
        }
        class Week
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };

            public IEnumerator GetEnumerator()
            {
                return new WeekEnumerator(days);
            }
        }
        class Program
        {
            static void MainRealiseIEnumerator(string[] args)
            {
                Week week = new Week();
                foreach (var day in week)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }


    class GeneralizedDoubles
    {
        class Week
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            public IEnumerator<string> GetEnumerator()
            {
                return new WeekEnumerator(days);
            }
        }
        class WeekEnumerator : IEnumerator<string>
        {
            string[] days;
            int position = -1;
            public WeekEnumerator(string[] days)
            {
                this.days = days;
            }

            public string Current
            {
                get
                {
                    if (position == -1 || position >= days.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return days[position];
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

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

            public void Reset()
            {
                position = -1;
            }
            public void Dispose() { }
        }
        class Program
        {
            static void MainGeneralizedDoubles(string[] args)
            {
                Week week = new Week();
                foreach (var day in week)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
