using System;

namespace GlobalNamespaces
{
    class C1
    {
        int n1;
        public C1 (int n1) => this.n1 = n1;
        public void Info() => Console.WriteLine($"n1: {n1}");
    } 
}