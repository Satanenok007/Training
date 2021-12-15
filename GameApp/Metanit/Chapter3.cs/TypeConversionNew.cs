using System;

namespace TypeConversoin
{
    class C1
    {
        static void F1(string[] args)
        {
            C3 obj1 = new C3(1, 2);
            C2 obj2 = obj1;
            Console.WriteLine(obj2.n1);

            object obj3 = new C3(3, 4);
            ((C2)obj3).Info();
            Console.WriteLine(obj3);

            C2 obj4 = new C3(5, 6);
            Console.WriteLine(obj4);

            C4 obj5 = (C4)obj4;
            Console.WriteLine(obj5);
        }
    }
    class C2
    {
        public int n1 { get; set; }
        public C2(int _n1)
        {
            n1 = _n1;
        }
        public void Info()
        {
            Console.WriteLine($"C2: {n1}");
        }
    }

    class C3 : C2
    {
        public int n2 { get; set; }
        public C3(int n1, int _n2) : base(n1)
        {
            n2 = _n2;
        }

    }
    class C4 : C2
    {
        public int n3 { get; set; }
        public C4(int c1, int _n3) : base(c1)
        {
            n3 = _n3;
        }
    }
}