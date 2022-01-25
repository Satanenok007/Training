using System;

namespace TwoLinkedLinkedList<T>
{
    class C1
    {
        static void F1(string[] args)
        {
            var obj1 = new List<string>() { "cats", "dogs", "frog", "fox", "fish", "lion" };

            var elements = obj1.First;
            while (elements != null)
            {
                Console.WriteLine(elements.Value);
                elements = elements.Next;
            }

            elements = obj1.Last;
            while (elements != null)
            {
                Console.WriteLine(elements.Value);
                elements = elements.Previous;
            }


            LinkedList<string> obj2 = new LinkedList<string>(obj1);
            foreach (string obj2 in obj2)
            {
                Console.WriteLine(obj2);
            }
            Console.WriteLine(obj2.Count);
            Console.WriteLine(obj2.First?.Value);
            Console.WriteLine(obj2.Last?.Value);


            var obj3 = new LinkedList<string>();
            obj3.AddLast("1");
            obj3.AddFirst("2");
            if (obj3.First != null)
            {
                obj3.AddAfter(obj3.First, "1.5");
            }
            foreach (var obj in obj3)
            {
                Console.WriteLine(obj3);
            }


            var obj4 = new LinkedList<C2>();
            obj4.AddLast(new C2("s1"));
            obj4.AddLast(new C2("s2"));
            obj4.AddLast(new C2("s3"));

            foreach (var obj in obj4)
            {
                Console.WriteLine(obj4.s1);
            }
        }
    }

    class C2
    {
        public string s1 { get; }
        public C2(string s1) => this.s1 = s1;
    }
}