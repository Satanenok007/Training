using System;

namespace ImplementationOfInterfacesInBaseAndDerivedClasses
{
    class Example
    {
        interface IMovable
        {
            void Move();
        }
        abstract class Person : IMovable
        {
            public abstract void Move();
        }
        class Driver : Person
        {
            public override void Move()
            {
                Console.WriteLine("Шофер ведет машину");
            }
        }

        interface IAction
        {
            void Move();
        }
        class BaseAction
        {
            public void Move()
            {
                Console.WriteLine("Move in BaseAction");
            }
        }
        class HeroAction : BaseAction, IAction
        {
        }
    }

    class ChangingTheImplementationOfInterfacesInDerivedClasses
    {
        interface IAction
        {
            void Move();
        }
        class BaseAction : IAction
        {
            public virtual void Move()
            {
                Console.WriteLine("Move in BaseAction");
            }
        }
        class HeroAction : BaseAction
        {
            public override void Move()
            {
                Console.WriteLine("Move in HeroAction");
            }
        }

        class Opion2
        {
            interface IAction
            {
                void Move();
            }
            class BaseAction : IAction
            {
                public void Move()
                {
                    Console.WriteLine("Move in BaseAction");
                }
            }
            class HeroAction : BaseAction
            {
                public new void Move()
                {
                    Console.WriteLine("Move in HeroAction");
                }
            }
        }

        class Opion3
        {
            interface IAction
            {
                void Move();
            }
            class BaseAction : IAction
            {
                public void Move()
                {
                    Console.WriteLine("Move in BaseAction");
                }
            }
            class HeroAction : BaseAction, IAction
            {
                public new void Move()
                {
                    Console.WriteLine("Move in HeroAction");
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    BaseAction action1 = new HeroAction();
                    action1.Move();

                    IAction action2 = new HeroAction();
                    action2.Move();

                    HeroAction action3 = new HeroAction();
                    action3.Move();
                }
            }
        }

        class Opion4
        {
            interface IAction
            {
                void Move();
            }
            class BaseAction : IAction
            {
                public void Move()
                {
                    Console.WriteLine("Move in BaseAction");
                }
            }
            class HeroAction : BaseAction, IAction
            {
                public new void Move()
                {
                    Console.WriteLine("Move in HeroAction");
                }
                void IAction.Move()
                {
                    Console.WriteLine("Move in IAction");
                }
            }

            class Program
            {
                static void Main(string args)
                {
                    BaseAction action1 = new HeroAction();
                    action1.Move();

                    IAction action2 = new HeroAction();
                    action2.Move();

                    HeroAction action3 = new HeroAction();
                    action3.Move();
                }
            }
        }

        class Programs
        {
            static void Main(string[] args)
            {
                BaseAction action1 = new HeroAction();
                action1.Move();

                IAction action2 = new HeroAction();
                action2.Move();
            }
        }
    }
}