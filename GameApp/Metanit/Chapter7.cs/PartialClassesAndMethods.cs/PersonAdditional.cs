using System;

public partial class Person1
{
    public void Eat()
    {
        Console.WriteLine("I am eating");
    }
}

public partial class Person2
{
    partial void Read()
    {
        Console.WriteLine("I am reading a book");
    }
}