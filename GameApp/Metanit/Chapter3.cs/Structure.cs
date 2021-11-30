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
            // C2 obj3 = obj2 with { numb1 = 33 };
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
}