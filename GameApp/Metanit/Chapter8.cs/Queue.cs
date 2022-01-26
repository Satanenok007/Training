using System;
using System.Collections.Generic;

namespace Queues
{
    class C1
    {
        static void F1(string[] args)
        {
            Queue<string> obj1 = new Queue<string>(10);

            var obj2 = new List<string> { "Cat", "Kitten", "Adult" };
            Queue<string> obj3 = new Queue<string>(obj2);
            foreach (var person in obj3) Console.WriteLine(person);

            Console.WriteLine(obj3.Count);

            var obj4 = new Queue<string>();
            obj4.Enqueue("Cat: Prise");
            obj4.Enqueue("Kitten: Felix");
            obj4.Enqueue("Adult: Ponia");

            if (obj4.Count > 0)
            {
                var obj5 = obj4.Peek();
                obj4.Dequeue();
            }

            var ob1 = obj4.Dequeue();
            Console.WriteLine(ob1);
            var ob2 = obj4.Dequeue();
            Console.WriteLine(ob2);
            var ob3 = obj4.Dequeue();
            Console.WriteLine(ob3);


            var obj6 = new Queue<string>();
            obj6.Enqueue("forg");

            var result1 = obj6.TryDequeue(out var res1);
            if (result1)
            {
                Console.WriteLine(res1);
            }

            var result2 = obj6.TryDequeue(out var res2);
            if (result2)
            {
                Console.WriteLine(res2);
            }

            var list = new Queue<Purchares>();
            list.Enqueue(new Purchares("Milk"));
            list.Enqueue(new Purchares("apple"));
            list.Enqueue(new Purchares("Chiсken"));
        }
    }

    class Purchares
    {
        public string Purchases;
        public Purchares(string purchases) => Purchases = purchases;
    }

    class Shop
    {
        public void Buy(Queue<Purchares> buys)
        {
            while (buys.Count > 0)
            {
                var buy = buys.Dequeue();
                Console.WriteLine($"bought: {buy.Purchases}");
            }
            Console.WriteLine("everything is bought");
        }
    }
}