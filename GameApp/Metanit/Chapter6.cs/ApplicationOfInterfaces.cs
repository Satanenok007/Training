using System;
namespace ApplicationOfInterfaces
{
    class Program
    {
        interface IMovable
        {
            void Move();
        }

        class Person : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Человек идет");
            }
        }
        struct Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Машина едет");
            }

        }

        class Programs
        {
            static void Action(IMovable movable)
            {
                movable.Move();
            }
            static void MainMove(string[] args)
            {
                Person person = new Person();
                Car car = new Car();
                Action(person);
                Action(car);
            }
        }

        class ImplementationOfDefaultInterfaces
        {
            class Program
            {
                static void MainImplementationOfDefaultInterfaces(string[] args)
                {
                    IMovable p1 = new Person();
                    Car tesla = new Car();
                    p1.Move();
                    tesla.Move();
                }
            }

            interface IMovable
            {
                void Move()
                {
                    Console.WriteLine("Walking");
                }
            }
            class Person : IMovable { }
            class Car : IMovable
            {
                public void Move()
                {
                    Console.WriteLine("Driving");
                }
            }
        }

        class MultipleImplementationOfInterfaces
        {
            interface IAccount
            {
                int CurrentSum { get; }
                void Put(int sum);
                void Withdraw(int sum);
            }
            interface IClient
            {
                string Name { get; set; }
            }
            class Client : IAccount, IClient
            {
                int _sum;
                public string Name { get; set; }
                public Client(string name, int sum)
                {
                    Name = name;
                    _sum = sum;
                }

                public int CurrentSum { get { return _sum; } }

                public void Put(int sum) { _sum += sum; }

                public void Withdraw(int sum)
                {
                    if (_sum >= sum)
                    {
                        _sum -= sum;
                    }
                }
            }
            class Program
            {
                static void MainMultipleImplementationOfInterfaces(string[] args)
                {
                    Client client = new Client("Tom", 200);
                    client.Put(30);
                    Console.WriteLine(client.CurrentSum);
                    client.Withdraw(100);
                    Console.WriteLine(client.CurrentSum);
                }
            }
        }
    }
}