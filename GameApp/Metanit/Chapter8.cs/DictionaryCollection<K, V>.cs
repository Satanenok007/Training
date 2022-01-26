using System;
using System.Collections.Generic;

namespace DictionaryCollection<K, V>
{
    class C1
    {
        static void F1(string[] args)
        {
            Dictionary<int, string> obj1 = new Dictionary<int, string>();
            var obj2 = new Dictionary<int, string>()
            {
                {1, "Cat"},
                {2, "Dog"},
                {3, "Fox"}
            };

            var obj3 = new KeyValuePair<int, string>(10, "obj3");
            var obj4 = new List<KeyValuePair<int, string>>() { obj3 };
            var obj5 = new Dictionary<int, string>(obj4)
            {
                [1] = "1",
                [2] = "2",
                [3] = "3"
            };
            foreach (var ob1 in obj5)
            {
                Console.WriteLine($"key: {obj5.Key}, value: {obj5.Value}");
            }
            string obj6 = obj5[3];
            Console.WriteLine(obj6);
            obj5[3] = "10";
            Console.WriteLine(obj5[3]);

            var obj7 = Dictionary<string, string>();
            obj7.Add("1", "Nastya");

            var a = obj7.ContainsKey("1");
            Console.WriteLine($"1 {a}");

            var b = obj7.ContainsKey("2");
            Console.WriteLine($"2 {b}");

            var aa = obj7.ContainsValue("Nastya");
            Console.WriteLine($"Nastya: {a}");
            var bb = obj7.ContainsValue("Sofia");
            Console.WriteLine($"Sofia: {b}");

            obj7.Remove("1");

            Console.WriteLine($"Count: {obj7.Count}");
        }
    }
}