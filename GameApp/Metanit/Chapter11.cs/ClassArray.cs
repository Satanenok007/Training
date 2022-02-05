using System;

namespace ClassArray
{
    class C1
    {
        static void F1()
        {
            var obj1 = new string[] { "Nastya", "Tanya", "Rikki", "Kate", "Sofia" };

            int TanyaIndex = Array.BinarySearch(obj1, "Tanya");
            int NastyaFirstIndex = Array.IndexOf(obj1, "Nastya");
            int NastyaLastIndex = Array.LastIndexOf(obj1, "Nastya");
            int lengthFirstIndex = Array.FindIndex(obj1, person => person.Length > 3);
            int lengthLastIndex = Array.FindLastIndex(obj1, person => person.Length > 3);

            Console.WriteLine($"TanyaIndex: {TanyaIndex}");
            Console.WriteLine($"NastyaFirstIndex: {NastyaFirstIndex}");
            Console.WriteLine($"NastyaLastIndex: {NastyaLastIndex}");
            Console.WriteLine($"lengthFirstIndex: {lengthFirstIndex}");
            Console.WriteLine($"lengthLastIndex: {lengthLastIndex}");


            string? first = Array.Find(obj1, ob1 => ob1.Length > 3);
            Console.WriteLine(first);
            string? last = Array.FindLast(obj1, ob1 => ob1.Length > 3);
            Console.WriteLine(last);

            string[] group = Array.FindAll(obj1, ob1 => ob1.Length == 3);
            foreach (var ob1 in group) Console.WriteLine(ob1);


            Array.Reverse(obj1);

            foreach (var ob1 in obj1)
            {
                Console.Write($"{ob1} ");
            }


            Array.Resize(ref obj1, 4);

            foreach (var ob1 in obj1)
            {
                Console.Write($"{ob1} ");
            }


            var obj2 = new string[3];
            Array.Copy(obj1, 1, obj2, 0, 3);

            foreach (var ob1 in obj2)
            {
                Console.Write($"{ob1} ");
            }


            Array.Sort(obj1, 1, 3);

            foreach (var person in obj1)
            {
                Console.Write($"{person} ");
            }
        }
    }
}