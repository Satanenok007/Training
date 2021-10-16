using System;
using Persons = NamespacesAliasesAndStaticImports.User;
using Printer = System.Console;

namespace NamespacesAliasesAndStaticImports
{
    class Program
    {
        static void MainNamespacesAliasesAndStaticImports(string[] args)
        {
            Account account = new Account(4);
            Persons person = new Persons();
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

    class Example2
    {
        class Program
        {
            static void MainExample2(string[] args)
            {
                Order order1 = new Order(6);
                Persons person1 = new Persons();
                person1.name = "Jack";
                Printer.WriteLine(person1.name);
            }
        }
        class Order
        {
            public int Id { get; private set; }
            public Order(int _id)
            {
                Id = _id;
            }
        }

        class User
        {
            public string name;
        }
    }
}