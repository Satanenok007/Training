using System;

namespace InheritanceOfGeneralizedTypes
{
    class Options1
    {
        class Account<T>
        {
            public T Id { get; private set; }
            public Account(T _id)
            {
                Id = _id;
            }
        }

        class UniversalAccount<T> : Account<T>
        {
            public UniversalAccount(T id) : base(id)
            {

            }
        }

        class Program
        {
            static void MainOp1(string[] args)
            {
                Account<string> acc1 = new Account<string>("34");
                Account<int> acc3 = new UniversalAccount<int>(45);
                UniversalAccount<int> acc2 = new UniversalAccount<int>(33);
                Console.WriteLine(acc1.Id);
                Console.WriteLine(acc2.Id);
                Console.WriteLine(acc3.Id);
            }
        }
    }

    class Options2
    {
        class Account<T>
        {
            public T Id { get; private set; }
            public Account(T _id)
            {
                Id = _id;
            }
        }

        class StringAccount : Account<string>
        {
            public StringAccount(string id) : base(id)
            {
            }
        }

        class Program
        {
            static void MainOp2(string[] args)
            {
                StringAccount acc4 = new StringAccount("438767");
                Account<string> acc5 = new StringAccount("43875");
                Console.WriteLine(acc4);
                Console.WriteLine(acc5);
            }
        }
    }

    class Options3
    {
        class Account<T>
        {
            public T Id { get; private set; }
            public Account(T _id)
            {
                Id = _id;
            }
        }

        class IntAccount<T> : Account<int>
        {
            public T Code { get; set; }
            public IntAccount(int id) : base(id)
            {
            }
        }

        class Program
        {
            static void MainOp3(string[] args)
            {
                IntAccount<string> acc7 = new IntAccount<string>(5) { Code = "r4556" };
                Account<int> acc8 = new IntAccount<long>(7) { Code = 4587 };
                Console.WriteLine(acc7.Id);
                Console.WriteLine(acc8.Id);
            }
        }
    }

    class Options4
    {
        class Account<T>
        {
            public T Id { get; private set; }
            public Account(T _id)
            {
                Id = _id;
            }
        }

        class MixedAccount<T, K> : Account<T>
        where K : struct
        {
            public K Code { get; set; }
            public MixedAccount(T id) : base(id)
            {

            }
        }

        class Program
        {
            static void MainOp4(string[] args)
            {
                MixedAccount<string, int> acc9 = new MixedAccount<string, int>("456") { Code = 356 };
                Account<string> acc10 = new MixedAccount<string, int>("9867") { Code = 35678 };
                Console.WriteLine(acc9.Id);
                Console.WriteLine(acc10.Id);
            }
        }
    }
}