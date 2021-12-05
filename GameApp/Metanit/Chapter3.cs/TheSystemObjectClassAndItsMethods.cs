using System;

namespace TheSystemObjectClassAndItsMethods
{
    class C1
    {
        static void F1()
        {
            С3 cl1 = new С3 { n3 = "n2" };
            Console.WriteLine(cl1.ToString());

            С2 cl2 = new С2 { n1 = 15, n2 = 34 };
            Console.WriteLine(cl2.ToString());
            Console.WriteLine(cl2.GetHashCode());
            Console.WriteLine(cl2.GetType());
        }
    }
    class С2
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public override string ToString()
        {
            return $"n1: {n1}, n2: {n2}";
        }
        public override int GetHashCode()
        {
            return n1.GetHashCode();
        }
    }
    class С3
    {
        public string n3 { get; set; }
    }
}