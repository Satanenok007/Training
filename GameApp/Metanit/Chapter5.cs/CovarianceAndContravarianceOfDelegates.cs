using System;

namespace CovarianceAndContravarianceOfDelegates
{
    class Program
    {
        class Covariance
        {
            class Person
            {
                public string Name { get; set; }
            }
            class Client : Person { }

            delegate Person PersonFactory(string name);
            static void Main(string[] args)
            {
                PersonFactory personDel;
                personDel = BuildClient; // ковариантность
                Person p = personDel("Tom");
                Console.WriteLine(p.Name);
            }
            private static Client BuildClient(string name)
            {
                return new Client { Name = name };
            }
        }


        class Contravariance
        {
            class Person
            {
                public string Name { get; set; }
            }
            class Client : Person { }

            delegate void ClientInfo(Client client);
            static void Main(string[] args)
            {
                ClientInfo clientInfo = GetPersonInfo; // контравариантность
                Client client = new Client { Name = "Alice" };
                clientInfo(client);
            }
            private static void GetPersonInfo(Person p)
            {
                Console.WriteLine(p.Name);
            }
        }


        class CovarianceAndContravarianceInGeneralizedDelegates
        {
            class Person
            {
                public string Name { get; set; }
                public virtual void Display() => Console.WriteLine($"Person {Name}");
            }
            class Client : Person
            {
                public override void Display() => Console.WriteLine($"Client {Name}");
            }


            delegate T Builder<out T>(string name);
            static void Main(string[] args)
            {
                Builder<Client> clientBuilder = GetClient;
                Builder<Person> personBuilder1 = clientBuilder;     // ковариантность
                Builder<Person> personBuilder2 = GetClient;         // ковариантность

                Person p = personBuilder1("Tom");
                p.Display();
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
}