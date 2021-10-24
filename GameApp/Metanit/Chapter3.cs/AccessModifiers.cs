using System;

namespace AccessModifiers
{
    public class Class2
    {
        int id;
        private int order;
        protected private string keyword;
        protected string city;
        internal int age;
        protected internal string email;
        public string name;

        void Mdefault() => Console.WriteLine($"id: {id}");

        private void Mprivate() => Console.WriteLine($"order: {order}");

        protected private void MprotectedPrivate() => Console.WriteLine($"keyword: {keyword}");

        protected void Mprotected() => Console.WriteLine($"city: {city}");

        internal void Minternal() => Console.WriteLine($"age: {age}");

        protected internal void MprotectedInternal() => Console.WriteLine($"email: {email}");

        public void Mpublic() => Console.WriteLine($"name: {name}");
    }


    class Program
    {
        static void AccessModifier(string[] args)
        {
            Class2 obj1 = new Class2();
            obj1.name = "Naiton";
            obj1.email = "Naiton123@gmail.com";
            obj1.age = 16;

            obj1.Minternal();
            obj1.MprotectedInternal();
            obj1.Mpublic();
        }
    }
}