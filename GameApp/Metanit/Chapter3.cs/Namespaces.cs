using System;
using Namespases.Namespases2;

namespace Namespases
{
    namespace Namespases2
    {
        class A
        {
            string a;
            Namespases.B b;
            public A(string a, Namespases.B b)
            {
                this.a = a;
                this.b = b;
            }
            public void Info()
            {
                Console.WriteLine($"string: {a}");
                b.Info();
            }
        }
    }

    class B
    {
        int b;
        public B(int b) => this.b = b;
        public void Info() => Console.WriteLine($"int: {b}");
    }
}