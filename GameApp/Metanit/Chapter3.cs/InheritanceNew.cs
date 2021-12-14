using System;

namespace Inheritances
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2(10);
            obj1.Info();
            
            C3 obj2 = new C3(35, 21);
            obj2.Info();
        }
    }
    class C2
    {
        public int obj1 { get; set; }

        public C2(int _obj1)
        {
            obj1 = _obj1;
        }

        public void Info()
        {
            Console.WriteLine(obj1);
        }
    }

    class C3 : C2
    {
        public int obj2 { get; set; }

        public C3(int obj1, int _obj2)
            : base(obj1)
        {
            obj2 = _obj2;
        }
    }
}