using System;
using Person = TakeTheTeroubleToSpace.Person;
// using Printer = System.Console;
using static System.Console;

namespace TakeTheTeroubleToSpace
{
    class Person
    {
        public string name;
    }
    class Program
    {
        static void MainTakeTheTeroubleToSpace(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Sosia";
            //Printer.WriteLine(p1.name);
            WriteLine(p1.name);
        }
    }
}
