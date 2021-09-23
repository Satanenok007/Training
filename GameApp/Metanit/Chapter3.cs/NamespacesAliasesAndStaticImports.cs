using System;
using Person = NamespacesAliasesAndStaticImports.User;
using Printer = System.Console;

namespace NamespacesAliasesAndStaticImports
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(4);
            Person person = new Person();
            person.name = "Mason";
            Printer.WriteLine(person.name);
        }
    }
    class Account
    {
        public int Id { get; private set; }
        public Account(int _id)
        {
            Id = _id;
        }
    }

    class User
    {
        public string name;
    }
}