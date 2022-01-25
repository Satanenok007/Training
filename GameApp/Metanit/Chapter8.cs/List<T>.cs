using System;

namespace List<T>
{
    class C1
    {
        static void F1(string[] args)
        {
            List<string> obj1 = new List<string>() { "cat", "kitten", "adult" };

            obj1.Add("cat Prise");
            obj1.AddRange(new[] { "kitten Saimon", "adilt Ponia" });
            obj1.Insert(0, "cats: ");
            obj1.InsertRange(1, new string[] { "kitten Sal'ma" });

            obj1.Remove("cats: ");
            obj1.RemoveAt(1);
            obj1.RemoveAll(obj1 => obj1.Length == 6);
            obj1.RemoveRange(0, 2);

            var range = obj1.GetRange(1, 3);
            string[] arr1 = new string[3];
            obj1.Copy(0, arr1, 0, 3);


            int obj2 = obj1[0];
            Console.WriteLine(obj2);
            obj1[0] = "www";
            Console.WriteLine(obj1[0]);


            var obj3 = new List<string>() { "1", "2", "3" };
            foreach (var obj3 in obj3)
            {
                Console.WriteLine(obj3);
            }
            var obj4 = new List<string>(obj2) { "4" };
            Console.WriteLine(obj3.Count);


            List<int> obj5 = new List<int>(10);

            var obj6 = new List<int>() { 1, 21, 300, 4130, 50000, 611, 67, 82, 900 };
            var n1 = obj6.Contains(10);
            var n2 = obj6.Contains(21);
            var n3 = obj6.Exists(o => o.Length == 2);
            obj6.Reserve(1, 5);

            List<C2> obj7 = new List<C2>()
            {
                new C2(10),
                new C2(20),
                new C2(30)
            };
        }
    }

    class C2
    {
        public int n1 { get; }
        public C2(int n1) => this.n1 = n1;
    }
}