using System;
using System.Collections.Generic;

namespace StackCollection
{
    class C1
    {
        static void F1(string[] args)
        {
            Stack<string> obj1 = new Stack<string>();

            var obj2 = new List<string>() { "Frog", "Cat", "Elephand", "Fox" };
            Stack<string> obj3 = new Stack<string>(obj2);
            foreach (var obj in obj3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(obj3.Count);


            var obj4 = new Stack<string>();
            obj4.Push("Cat");
            obj4.Push("Kitten");
            obj4.Push("Adult");

            string headob = obj4.Peek();
            Console.WriteLine(headob);

            string ob1 = obj3.Pop();
            Console.WriteLine(ob1);

            string ob2 = obj3.Pop();
            Console.WriteLine(ob2);

            string ob3 = obj3.Pop();
            Console.WriteLine(ob3);

            if (obj3.Count > 0)
            {
                var ob = obj3.Peek();
                obj3.Pop();
            }


            var obj5 = new Stack<string>();
            obj5.Push("Ponia");

            var delete1 = obj5.TryPop(out var o1);
            if (delete1)
            {
                Console.WriteLine(o1);
            }

            var delete2 = obj5.TryPeek(out var o2);
            if (delete2)
            {
                Console.WriteLine(o2);
            }
        }
    }
}