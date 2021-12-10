using System;

namespace Structure
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new();
            obj1.numb1 = 100;
            obj1.GetInfo();

            C2 obj2 = new C2 { numb1 = 20, numb2 = 40 };
            obj2.GetInfo();
            

            C3 obj3 = new C3() {n1 = 1, n2 = 2};
            obj3.F1();

            C3 obj4 = new C3();
            obj4.n1 = 3;
            obj4.n2 = 4;
            obj4.F1();

            C3 obj5 = new();
            obj5.n1 = 5;
            obj5.n2 = 6;
            obj5.F1();

            C3 obj6;
            obj6.n1 = 7;
            obj6.n2 = 8;
            obj6.F1();

        }
    }

    struct C2
    {
        public int numb1;
        public int numb2;
        public C2(int n1 = 0, int n2 = 10)
        {
            this.numb1 = n1;
            this.numb2 = n2;
        }
        public void GetInfo()
        {
            Console.WriteLine($"numb1: {numb1}, numb2: {numb2}");
        }
    }

    struct C3
    {
        public int n1;
        public int n2;

        public C3(int n1 = 0, int n2 = 0)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void F1()
        {
            Console.WriteLine($"{n1}, {n2}");
        }
    }
}