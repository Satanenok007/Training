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

        class C2
        {
            public void F2(int n1, int n2)
            {
                int res = n1 + n2;
                Console.WriteLine(res);
            }

            public void F2(int n1, int n2, int n3)
            {
                int res = n1 + n2 + n3;
                Console.WriteLine(res);
            }

            public void F2(int n1, int n2, int n3, int n4)
            {
                int res = n1 + n2 + n3 + n4;
                Console.WriteLine(res);
            }

            class Program
            {
                static void F2(string[] args)
                {
                    C1 obj1 = new C1();
                    obj1.F1(1, 2);
                    obj1.F1(1, 2, 3);
                    obj1.F1(1, 2, 3, 4);

                    C2 obj2 = new C2();
                    obj2.F2(10, 11);
                    obj2.F2(4, 9, 3);
                    obj2.F2(5, 7, 12, 8);
                }
            }
        }
    }
}