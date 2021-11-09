using System;

namespace Generalization
{
    class C1<T>
    {
        public static T n1;
        public T n2 = default(T);
        public string n3 { get; set; }
    }

    class Transaction<U, V>
    {
        public U n4 { get; set; }
        public U n5 { get; set; }
        public V n6 { get; set; }
        public int n7 { get; set; }
    }

    class C2
    {
        static void F1(string[] args)
        {
            C1<int> obj1 = new C1<int> { n3 = "n3" };
            C1<int>.n1 = 1;
            C1<string> obj2 = new C1<string> { n3 = "n3" };
            C1<string>.n1 = "12";

            obj1.n2 = 123;
            obj2.n2 = "1234";
            int n21 = obj1.n2;
            string n22 = obj2.n2;

            Console.WriteLine(n21);
            Console.WriteLine(n22);
            Console.WriteLine(C1<int>.n1);
            Console.WriteLine(C1<string>.n1);


            C1<int> obj3 = new C1<int> { n2 = 1111, n3 = "1112" };
            C1<int> obj4 = new C1<int> { n2 = 222, n3 = "2221" };

            Transaction<C1<int>, string> transaction1 = new Transaction<C1<int>, string>
            {
                n4 = obj1,
                n5 = obj4,
                n6 = "123456789",
                n7 = 12345
            };
        }
    }
}