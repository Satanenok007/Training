using System;

namespace Generalizations
{
    class A
    {
        static void F1()
        {
            B<int> obj1 = new B<int>(123, "aaa");
            B<string> obj2 = new B<string>("dd123", "bbb");

            int o1n1 = obj1.n1;
            string o2n1 = obj2.n1;

            Console.WriteLine(o1n1);
            Console.WriteLine(o2n1);
        }
    }

    class B<A>
    {
        public A n1 { get; set; }
        public string n2 { get; set; }
        public B(A n1, string n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
    }

}