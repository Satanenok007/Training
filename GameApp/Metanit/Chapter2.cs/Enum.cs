using System;

namespace Enum
{
    class Enum
    {
        static void F21()
        {
            DayWeek D;

            D = DayWeek.Sunday;
            D++;
            D += 2;
            D += 10;

            D = DayWeek.Friday;
            --D;
            D = D - 8;
        }
    }
    enum DayWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
}