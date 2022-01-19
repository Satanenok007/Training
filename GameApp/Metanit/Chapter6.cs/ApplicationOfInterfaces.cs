using System;

namespace ApplicationOfInterfaces
{
    class C1
    {
        static void F1(string[] args)
        {
            Adult cat1 = new Adult();
            Kid cat2 = new Kid();
            Info(cat1);
            Info(cat2);
            void Info(ICat cat) => cat.Children();

            Numb numb1 = new Numb(10);
            numb1.Info(); 
        }
    }
    interface ICat
    {
        void Children();
    }
    class Adult : ICat
    {
        public void Children() => Console.WriteLine("Cat");
    }
    class Kid : ICat
    {
        public void Children() => Console.WriteLine("Kitten");
    }

    interface INumber
    {
        int numb1 { get; set; }
    }
    interface Info
    {
        void Info();
    }
    class Numb : INumber, Info
    {
        public int numb1 { get; set; }
        public Numb(int n1) => numb1 = n1;
        public void Info() => Console.WriteLine(numb1);
    }
}