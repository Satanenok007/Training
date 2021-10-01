using System;

namespace ExplicitImplementationOfInterfaces
{
    class Program
    {
        interface IAction
        {
            void Move();
        }
        class BaseAction : IAction
        {
            void IAction.Move()
            {
                Console.WriteLine("Move in Base Class");
            }
        }

        class Person : ISchool, IUniversity
        {

            void ISchool.Study()
            {
                Console.WriteLine("Учеба в школе");
            }
            void IUniversity.Study()
            {
                Console.WriteLine("Учеба в университете");
            }
        }

        interface ISchool
        {
            void Study();
        }

        interface IUniversity
        {
            void Study();
        }

        class Programs
        {
            static void Main(string[] args)
            {
                BaseAction action = new BaseAction();
                ((IAction)action).Move();

                IAction action2 = new BaseAction();
                action2.Move();

                Person p = new Person();
                ((ISchool)p).Study();
                ((IUniversity)p).Study();
            }
        }

        class AccessModifiers
        {
            interface IMovable
            {
                protected internal void Move();
                protected internal string Name { get; set; }
                delegate void MoveHandler();
                protected internal event MoveHandler MoveEvent;
            }
            class Person : IMovable
            {
                string IMovable.Name { get; set; }

                IMovable.MoveHandler _moveEvent;
                event IMovable.MoveHandler IMovable.MoveEvent
                {
                    add => _moveEvent += value;
                    remove => _moveEvent -= value;
                }

                void IMovable.Move()
                {
                    Console.WriteLine("Person is walking");
                    _moveEvent();
                }
            }
            class Program
            {
                static void Main(string[] args)
                {
                    IMovable mov = new Person();
                    mov.MoveEvent += () => Console.WriteLine("IMovable is moving");
                    mov.Move();
                }
            }

        }
    }
}