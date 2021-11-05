using System;

namespace VirtualMethodsAndProperties
{
    class C1
    {
        public int N1 { get; set; }
        public C1(int n1)
        {
            N1 = n1;
        }
        public virtual void Info()
        {
            Console.WriteLine(N1);
        }

        class C2 : C1
        {
            public int N2 { get; set; }
            public C2(int n1, int n2)
                : base(n1)
            {
                N2 = n2;
            }

            public override void Info()
            {
                Console.WriteLine($"{N1} =  {N2}");
            }
        }

        class C3
        {
            public virtual decimal n3 { get; set; }
        }
        class C4 : C3
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
                    if (value > 10)
                    {
                        n4 = value;
                    }
                }
            }
        }

        class Program
        {
            static void F1(string[] args)
            {
                C1 obj1 = new C1(123);
                obj1.Info();

                C2 obj2 = new C2(123, 586);
                obj2.Info();

                C4 obj3 = new C4 { n3 = 6000 };
                obj3.n3 = 490;
                Console.WriteLine(obj3.n3);
            }
        }
    }
}