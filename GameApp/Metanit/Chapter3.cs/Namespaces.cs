using System;
using Namespaces.N1;

C1 cl1 = new C1(10);
cl1.GetInfo();

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