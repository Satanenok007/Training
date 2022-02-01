using System;

namespace FormattingDatesAndTimes
{
    class C1
    {
        static void F1()
        {
            DateTime time1 = DateTime.Now;

            Console.WriteLine($"D: {time1.ToString("D")}");
            Console.WriteLine($"d: {time1.ToString("d")}");
            Console.WriteLine($"F: {time1.ToString("F")}");
            Console.WriteLine($"f: {time1:f}");
            Console.WriteLine($"G: {time1:G}");
            Console.WriteLine($"g: {time1:g}");
            Console.WriteLine($"M: {time1:M}");
            Console.WriteLine($"O: {time1:O}");
            Console.WriteLine($"o: {time1:o}");
            Console.WriteLine($"R: {time1:R}");
            Console.WriteLine($"s: {time1:s}");
            Console.WriteLine($"T: {time1:T}");
            Console.WriteLine($"t: {time1:t}");
            Console.WriteLine($"U: {time1:U}");
            Console.WriteLine($"u: {time1:u}");
            Console.WriteLine($"Y: {time1:Y}");

            DateTime time2 = DateTime.Now;
            Console.WriteLine(time2.ToString("hh:mm:ss"));
            Console.WriteLine(time2.ToString("dd.MM.yyyy"));
        }
    }
}