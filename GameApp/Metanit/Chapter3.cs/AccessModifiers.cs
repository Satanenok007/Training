using System;

namespace AccessModifiers
{
    class C1
    {
        static void F1()
        {
            C2 cl2 = new C2();
            Console.WriteLine(cl2.n5);
            Console.WriteLine(cl2.n6);
            Console.WriteLine(cl2.n7);
            cl2.PrintInternal();
            cl2.PrintProtectedInternal();
            cl2.PrintPublic();
        }
    }
    class C2
    {
        string n1 = "default";
        private string n2 = "private";
        protected private string n3 = "protected private";
        protected string n4 = "protected";
        internal string n5 = "internal";
        protected internal string n6 = "protected internal";
        public string n7 = "public";

        void Print() => Console.WriteLine(n1);

        private void PrintPrivate() => Console.WriteLine(n2);

        protected private void PrintProtectedPrivate() => Console.WriteLine(n3);

        protected void PrintProtected() => Console.WriteLine(n4);

        internal void PrintInternal() => Console.WriteLine(n5);

        protected internal void PrintProtectedInternal() => Console.WriteLine(n6);

        public void PrintPublic() => Console.WriteLine(n7);

    }
}