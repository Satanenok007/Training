using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(55);
            list.AddRange(new string[] { "Hello", "world" });

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[0]);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}