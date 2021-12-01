using System;
using GlobalNamespaces;

class C2
{
    int n1;
    C1 n2;
    public C2(int n1, C1 n2)
    {
        this.n1 = n1;
        this.n2 = n2;
    }
    public void Info()
    {
        Console.WriteLine($"n1: {n1}");
        n2.Info();
    }
}