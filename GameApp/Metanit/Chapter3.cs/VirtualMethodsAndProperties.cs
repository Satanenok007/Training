using System;

namespace VirtualMethodsAndProperties
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 cl2 = new C2("n1");

            C3 cl3 = new C3("n1", "n2");
            cl3.Info();

            C5 cl5 = new C5 { n3 = 30 };
            cl5.n3 = 40;
            Console.WriteLine(cl5.n3);
        }
    }
    class C2
    {
        public string n1 { get; set; }
        public C2(string _n1)
        {
            n1 = _n1;
        }
        public virtual void Info()
        {
            Console.WriteLine(n1);
        }
    }
    class C3 : C2
    {
        public string n2 { get; set; }
        public C3(string n1, string n2)
        : base(n1)
        {
            this.n2 = n2;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"n2: {n2}");
        }
    }

    class C4
    {
        public virtual decimal n3 { get; set; }
    }
    class C5 : C4
    {
        private decimal n4;
        public override decimal n3
        {
            get
            {
                return n4;
            }
            set
            {
                if (value > 20)
                {
                    n4 = value;
                }
            }
        }
    }
}