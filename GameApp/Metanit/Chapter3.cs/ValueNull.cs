using System;

namespace ValueNull
{
    class C1
    {
        static void F1(string[] args)
        {
            object i = null;
            object j = i ?? 1;

            object w = 12;
            object q = w ?? 22;

            C2 obj1 = new C2();
            string temp = obj1?.n1?.n2?.n3 ?? "не установлено";
            Console.WriteLine(obj1.n1.n2.n3);
        }
    }

    class C2
    {
        public C3 n1 { get; set; }
    }

    class C3
    {
        public C4 n2 { get; set; }
    }

    class C4
    {
        public string n3 { get; set; }
    }
}
// new