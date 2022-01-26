using System;
using System.Collections.Generic;

namespace StackCollection<T>
{
    class C1
    {
        static void F1(string[] args)
        {
            Stack<string> obj1 = new Stack<string>();

            var obj2 = new Stack<string>() { "Frog", "Cat", "Elephand", "Fox" };
            Stack<string> obj3 = new Stack<string>(obj2);
            foreach (var ob1 in obj3)
            {
                Console.WriteLine(ob1);
            }
            Console.WriteLine(obj3.Count);


            var obj3 = new Stack<string>();
            obj3.Push("Cat");
            obj3.Push("Kitten");
            obj3.Push("Adult");

            string headob = obj3.Peek();
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


            var obj4 = new Stack<string>();
            obj4.Push("Ponia");

            var delete1 = obj4.TryPop(out var o1);
            if (delete1)
            {
                Console.WriteLine(o1);
            }

            var delete2 = obj4.TryPeek(out var o2);
            if (delete2)
            {
                Console.WriteLine(o2);
            }
        }
    }
}