using System;

int x = 50;
byte y = (byte)x;
int z = y;

namespace overloadingOfTypeConversionOperators
{
    class Program
    {
        class Counter
        {
            public int Seconds { get; set; }
            public static implicit operator Counter(int x)
            {
                return new Counter { Seconds = x };
            }
            public static explicit operator int(Counter counter)
            {
                return counter.Seconds;
            }
        }

        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Seconds = 23 };

            int x = (int)counter1;
            Console.WriteLine(x);

            Counter counter2 = x;
            Console.WriteLine(counter2.Seconds);
        }


        class Timer
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Second { get; set; }
        }
        class Counters
        {
            public int Second { get; set; }
            public static implicit operator Counters(int i)
            {
                return new Counters { Second = i };
            }

            public static explicit operator int(Counters counters)
            {
                return counters.Second;
            }

            public static explicit operator Counters(Timer timer)
            {
                int h = timer.Hours * 3600;
                int m = timer.Minutes * 60;
                return new Counters { Second = h + m + timer.Second };
            }
            public static implicit operator Timer(Counters counters)
            {
                int h = counters.Second / 3600;
                int m = (counters.Second % 3600) / 60;
                int s = counters.Second % 60;
                return new Timer { Hours = h, Minutes = m, Second = s };
            }
        }

        // static void Mains(string[] args)
        // {
        //     Counter counter1 = new Counter { Seconds = 115 };

        //     Timer timer = counter1;
        //     Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55

        //     Counter counter2 = (Counter)timer;
        //     Console.WriteLine(counter2.Seconds);  //115

        //     Console.ReadKey();
        // }
    }
}