using System;
using System.Collections.ObjectModel;


namespace ObservableCollectionClass
{
    class C1
    {
        static void F1(string[] args)
        {
            ObservableCollection<string> obj1 = new ObservableCollection<string>();
            var obj2 = new ObservableCollection<string>(new string[] { "Dog", "Frog", "Elephand", "Fox" });
            var obj3 = new ObservableCollection<string>
            {
                "Kitten",
                "Adult",
                "Cat"
            };
            Console.WriteLine(obj3[0]);
            obj3[0] = "cats";
            Console.WriteLine(obj3[0]);

            foreach (var ob3 in obj3)
            {
                Console.WriteLine(ob3);
            }

            for (int x = 0; x < obj3.Count; x++)
            {
                Console.WriteLine(obj3[x]);
            }

            var obj4 = new ObservableCollection<string>();
            obj4.Add("2");
            obj4.Insert(0, "1");
            bool True = obj4.Contains("2");
            bool False = obj4.Contains("3");
            obj4.Remove("1");
            obj4.RemoveAt(0);
        }
    }
}