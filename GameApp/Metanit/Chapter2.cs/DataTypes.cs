using System;

namespace DataTypes
{
    class DataTypes
    {
        static void F4()
        {
            bool x1 = true;
            bool x2 = false;
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            byte x3 = 1; // хранит целое число от 0 до 255
            byte x4 = 2;
            Console.WriteLine(x3);
            Console.WriteLine(x4);

            sbyte x5 = -128; //хранит целое число от -128 до 127
            sbyte x6 = 127;
            Console.WriteLine(x5);
            Console.WriteLine(x6);

            short x7 = -32768; // хранит целое число от -32768 до 32767
            short x8 = 32767;
            Console.WriteLine(x7);
            Console.WriteLine(x8);

            ushort x9 = 0; // хранит целое число от 0 до 65535
            ushort x10 = 65535;
            Console.WriteLine(x9);
            Console.WriteLine(x10);

            int x11 = -2147483648; // хранит целое число от -2147483648 до 2147483647
            int x12 = 2147483647;
            Console.WriteLine(x11);
            Console.WriteLine(x12);

            uint x13 = 0; // хранит целое число от 0 до 4294967295
            uint x14 = 4294967295;
            Console.WriteLine(x13);
            Console.WriteLine(x14);

            long x15 = -9223372036854775808; // хранит целое число от  -9223372036854775808 до 9223372036854775807
            long x16 =  9223372036854775807; 
            Console.WriteLine(x15);
            Console.WriteLine(x16);

            ulong x17 = 0; // хранит целое число от 0 до 18446744073709551615
            ulong x18 = 18446744073709551615;
            Console.WriteLine(x17);
            Console.WriteLine(x18);

            char x19 = 'P';
            Console.WriteLine(x19);

            string x20 = "Find";
            Console.WriteLine(x20);

            object x21 = 87;
            object x22 = "Find";
        }
    }
}