using System;

namespace MethodOverloading
{
    class C1
    {
        public void F1(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public void F1(int x, int y, int z)
        {
            int result = x + y + z;
            Console.WriteLine(result);
        }

        public void F1(int x, int y, int z, int j)
        {
            int result = x + y + z + j;
            Console.WriteLine(result);
        }

        class Program
        {
            static void F2(string[] args)
            {
                C1 obj1 = new C1();
                obj1.F1(1,2);
                obj1.F1(1,2,3);
                obj1.F1(1,2,3,4);
            }
        }
    }
}