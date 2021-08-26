using System;

namespace AccessModifiers
{
    public class Person
    {
        int id;  // все равно, что private int defaultVar;

        private int salary; // поле доступно только из текущего класса

        protected private string placeOfResidence; // доступно из текущего класса и производных классов, которые определены в этом же проекте

        protected string profession; // доступно из текущего класса и производных классов

        internal int age; // доступно в любом месте текущего проекта

        protected internal string surname; // доступно в любом месте текущего проекта и из классов-наследников в других проектах

        public string name; // доступно в любом месте программы, а также для других программ и сборок


        void defaultMethod() => Console.WriteLine($"id: {id}"); // по умолчанию имеет модификатор private

        private void privateMethod() => Console.WriteLine($"salary: {salary}"); // метод доступен только из текущего класса

        protected private void protectedPrivateMethod() => Console.WriteLine($"place of residence: {placeOfResidence}"); // доступен из текущего класса и производных классов, которые определены в этом же проекте

        protected void protectedMethod() => Console.WriteLine($"profession: {profession}"); // доступен из текущего класса и производных классов

        internal void internalMethod() => Console.WriteLine($"age: {age}"); // доступен в любом месте текущего проекта

        protected internal void protectedInternalMethod() => Console.WriteLine($"surname: {surname}"); // доступен в любом месте текущего проекта и из классов-наследников в других проектах

        public void publicMethod() => Console.WriteLine($"name: {name}"); // доступен в любом месте программы, а также для других программ и сборок
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "Sofia";
            person1.surname = "Kmita";
            person1.age = 16;

            person1.internalMethod();
            person1.protectedInternalMethod();
            person1.publicMethod();
            // другие поля и методы класса нам не доступны, поскольку имеют препядствующие модификаторы доступа
        }
    }
}