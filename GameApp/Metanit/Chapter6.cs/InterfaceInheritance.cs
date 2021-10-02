using System;

namespace InterfaceInheritance
{
    class Program
    {
        class Example1
        {
            interface IAction
            {
                void Move();
            }
            interface IRunAction : IAction
            {
                void Run();
            }
            class BaseAction : IRunAction
            {
                public void Move()
                {
                    Console.WriteLine("Move");
                }
                public void Run()
                {
                    Console.WriteLine("Run");
                }
            }
        }

        class KeywordNew
        {
            class RunAction : IRunAction
            {
                public void Move()
                {
                    Console.WriteLine("I am running");
                }
            }

            interface IAction
            {
                void Move();
            }
            interface IRunAction : IAction
            {
                new void Move();
            }
        }

        class Example3
        {
            public interface IAction
            {
                void Move();
            }
            internal interface IRunAction : IAction
            {
                void Run();
            }
        }
    }
}