using System;
using Namespases.Namespases2;

A a1 = new A("a1");
a1.Info();

Namespases.Namespases2.A a2 = new A("a2");
A a3 = new A("a3", a2);
a3.Info();



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