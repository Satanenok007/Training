using System;

namespace AbstractClassesAndClassMembers
{
    abstract class Moves
    {
        public string Name { get; set; }
        public Moves(string name)
        {
            Name = name;
        }
        public abstract void Info();
    }

    class Series : Moves
    {
        public int NumberOfEpisodes { get; set; }
        public Series(string name, int numberOfEpisodes)
         : base(name)
        {
            NumberOfEpisodes = numberOfEpisodes;
        }
        public override void Info()
        {
            Console.WriteLine($"Название: {Name}, количество серий: {NumberOfEpisodes}");
        }
    }

    class Program
    {
        static void Primes(string[] args)
        {
            Series series = new Series("Firefly", 14);
            series.Info();
        }
    }

    abstract class C1
    {
        public string Name { get; set; }
        public C1(string name)
        {
            Name = name;
        }
        public abstract void C3();
    }

    class C2 : C1
    {
        public int age { get; set; }
        public C2(string name, int Age)
         : base(name)
        {
            age = Age;
        }
        public override void C3()
        {
            Console.WriteLine($"имя: {Name}, возраст: {age}");
        }
    }


    class Example2
    {
        abstract class A_Abstract
        {
            public int a;
        }

        class B : A_Abstract
        {
            public int b;
        }

        abstract class C_Abstract : B
        {
            public int c;
        }

        class D : C_Abstract
        {
            public int d;
        }

        class Program
        {
            static void Prime(string[] args)
            {
                B objB = new B();
                D objD = new D();

                objB.a = 23;
                objB.b = 33;

                objD.a = 77;
                objD.b = 777;
                objD.c = 7777;
                objD.d = 7777;
            }
        }
    }
}