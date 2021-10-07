using System;

public partial class Person1
{
    public void Move()
    {
        Console.WriteLine("I am moving");
    }
}

public partial class Person2
{
    partial void Read();
    public void DoSomething()
    {
        Read();
    }
}