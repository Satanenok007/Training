using System;

namespace CovarianceAndContravarianceOfDelegates
{
    class Covariance
    {
        class Person
        {
            public string Name { get; set; }
        }
        class Client : Person { }

        class Program
        {
            delegate Person PersonFactory(string name);
            static void MainDelPerson(string[] args)
            {
                PersonFactory personDel;
                personDel = BuildClient;
                Person p1 = personDel("Kate");
                Console.WriteLine(p1.Name);
            }
            private static Client BuildClient(string name)
            {
                return new Client { Name = name };
            }
        }
    }

    class CovarianceAndContravarianceInGeneralizedDelegates
    {
        class Person
        {
            public string Name { get; set; }
            public virtual void Display() => Console.WriteLine($"Person: {Name}");
        }
        class Client : Person
        {
            public override void Display() => Console.WriteLine($"Client: {Name}");
        }

        class Program
        {
            delegate T Builder<out T>(string name);
            static void MainDelBilder(string[] args)
            {
                Builder<Client> clientBuilder = GetClient;
                Builder<Person> personBuilder1 = clientBuilder;
                Builder<Person> personBuilder2 = GetClient;

                Person p = personBuilder1("Alise");
                p.Display();

                Console.Read();
            }
            private static Person GetPerson(string name)
            {
                return new Person { Name = name };
            }
            private static Client GetClient(string name)
            {
                return new Client { Name = name };
            }
        }
    }

    class ContravariantGeneralizedDelegate
    {

        class Person
        {
            public string Name { get; set; }
            public virtual void Display() => Console.WriteLine($"Person: {Name}");
        }
        class Client : Person
        {
            public override void Display() => Console.WriteLine($"Client: {Name}");
        }
        class Program
        {
            delegate void GetInfo<in T>(T item);
            static void MainDelGetInfo(string[] args)
            {
                GetInfo<Person> personInfo = PersonInfo;
                GetInfo<Client> clientInfo = personInfo;

                Client client = new Client { Name = "Sofia" };
                clientInfo(client);

            }
            private static void PersonInfo(Person p) => p.Display();
            private static void ClientInfo(Client cl) => cl.Display();
        }
    }
}