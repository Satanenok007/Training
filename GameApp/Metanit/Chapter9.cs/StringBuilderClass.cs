using System;
using System.Text;

namespace StringBuilderClass
{
    class C1
    {
        static void F1()
        {
            var obj1 = new StringBuilder("Paradise in hell");
            Console.WriteLine(obj1.ToString());

            Console.WriteLine($"Length: {obj1.Length}");
            Console.WriteLine($"Container: {obj1.Capacity}");

            var obj2 = new StringBuilder("Name: ");
            Console.WriteLine(obj2);
            Console.WriteLine($"Lebgth: {obj2.Length}");
            Console.WriteLine($"Container: {obj2.Capacity}");

            obj2.Append("Cat");
            Console.WriteLine(obj2);
            Console.WriteLine($"Длина: {obj2.Length}");
            Console.WriteLine($"Емкость: {obj2.Capacity}");

            obj2.Append("Prise");
            Console.WriteLine(obj2);
            Console.WriteLine($"Длина: {obj2.Length}");
            Console.WriteLine($"Емкость: {obj2.Capacity}");


            var obj3 = new StringBuilder("paradise in hell");
            obj3.Append(".");
            obj3.Insert(1,"world");
            Console.WriteLine(obj3);


            obj3.Replace("world", "hell");
            Console.WriteLine(obj3);

            obj3.Remove(3, 6);
            Console.WriteLine(obj3);

            string res = obj3.ToString();
            Console.WriteLine(res);
        }
    }
}