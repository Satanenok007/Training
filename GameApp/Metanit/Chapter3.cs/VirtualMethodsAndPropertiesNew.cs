using System;

namespace VirtualMethodsAndProperties
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2("a");

            C3 obj2 = new C3("a", "b");
            obj2.Info();

            C5 obj3 = new C5 { c = 10 };
            obj3.c = 15;
            Console.WriteLine(obj3.c);
        }
    }
    class C2
    {
        public string a { get; set; }
        public C2(string _a)
        {
            a = _a;
        }
        public virtual void Info()
        {
            Console.WriteLine(a);
        }
    }
    class C3 : C2
    {
        public string b { get; set; }
        public C3(string a, string b)
        : base(a)
        {
            this.b = b;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"n2: {b}");
        }
    }

    class C4
    {
        public virtual decimal c { get; set; }
    }
    class C5 : C4
    {
        private decimal d;
        public override decimal c
        {
            get
            {
                return d;
            }
            set
            {
                if (value > 20)
                {
                    d = value;
                }
            }
        }
    }
}