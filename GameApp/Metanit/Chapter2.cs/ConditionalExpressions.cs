using System;

namespace ConditionalExpressions
{
    class ConditionalExpressions
    {
        static void F9()
        {
            int x = 17;
            int y = 7;
            int z = 17;
            bool t = true;
            bool f = false;
            bool a;
            bool d;

            a = x == y;
            d = x != 17;
            a = y > x;
            d = y < x;
            a = x <= y;
            d = x >= y;

            a = (x < y) | (x > y); // true
            a = (z < y) || (y > x); //true
            d = (x == z) & (y < z); // true
            d = (x > y) && (x == z); //true
            d = (z > y) ^ (x < y); // true

            a = !t;  // false
            a = !f; //true
        }
    }
}