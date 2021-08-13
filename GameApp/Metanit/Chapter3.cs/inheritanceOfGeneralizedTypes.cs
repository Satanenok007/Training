using System;

namespace InheritanceOfGeneralizedTypes
{
    class Program
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

        class StringAccount : Account<string>
        {
            public StringAccount(string id) : base(id)
            {
            }
        }

        public static void Main(string[] args)
        {
            Account<string> acc1 = new Account<string>("34");
            Account<int> acc3 = new UniversalAccount<int>(45);
            UniversalAccount<int> acc2 = new UniversalAccount<int>(33);
            StringAccount acc4 = new StringAccount("438767");
            Account<string> acc5 = new StringAccount("43875");
            Console.WriteLine(acc1.Id);
            Console.WriteLine(acc2.Id);
            Console.WriteLine(acc3.Id);
        }
    }
}