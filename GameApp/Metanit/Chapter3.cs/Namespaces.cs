using System;
using Namespaces.N1;
using N1.N2;

C1 cl1 = new C1(10);
cl1.GetInfo();

N1.N2.C2 cl2 = new(123);
cl2.F1();

namespace Namespaces
{
    namespace N1
    {
        class C1
        {
            int n1;
            public C1(int n1) => this.n1 = n1;
            public void GetInfo() => Console.WriteLine(n1);
        }
    }
}

namespace N1
{
    namespace N2
    {
        class C2
        {
            int obj1;
            public C2(int obj1) => this.obj1 = obj1;
            public void F1() => Console.WriteLine(obj1);
        }
    }
}