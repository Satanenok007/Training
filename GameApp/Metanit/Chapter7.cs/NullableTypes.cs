using System;

namespace NullableTypes
{

    class Program
    {
        int? z1 = 5;
        bool? enabled1 = null;
        Double? d1 = 3.3;

        Nullable<int> z2 = 5;
        Nullable<bool> enabled2 = null;
        Nullable<System.Double> d2 = 3.3;
    }

    class Programs
    {
        static void MainNullableTypes(string[] args)
        {
            int? x = 7;
            Console.WriteLine(x.Value);
            Nullable<State> state = new State() { Name = "Narnia" };
            Console.WriteLine(state.Value.Name);
        }
    }
    struct State
    {
        public string Name { get; set; }
    }

    class programs
    {
        static void MainStrucruteState(string[] args)
        {
            int? x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is equal to null");
            }

            State? state = null;
            if (state.HasValue)
            {
                Console.WriteLine(state.Value.Name);
            }
            else
            {
                Console.WriteLine("state is equal to null");
            }
        }
    }

    class EqualityOfObjects
    {
        static void MainEqualityOfObjects(string[] args)
        {
            int? x1 = null;
            int? x2 = null;
            if (x1 == x2)
            {
                Console.WriteLine("объекты равны");
            }
            else
            {
                Console.WriteLine("объекты не равны");
            }
        }
    }

    class ConvertingNullableTypes
    {
        static void ConvertingNullableType()
        {
            int? x1 = null;
            if (x1.HasValue)
            {
                int x2 = (int)x1;
                Console.WriteLine(x2);
            }

            int x3 = 4;
            int? x4 = x3;
            Console.WriteLine(x4);

            int x5 = 4;
            long? x6 = x5;
            Console.WriteLine(x6);

            long x7 = 4;
            int? x8 = (int?)x7;

            long? x9 = 4;
            int? x10 = (int?)x9;

            long? x11 = 4;
            int x12 = (int)x11;
        }
    }
}