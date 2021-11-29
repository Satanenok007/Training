using System;

namespace ConstructorsInitializersAndDconstructors
{
    class C1
    {
        static void Main()
        {
            C2 obj1 = new C2();
            obj1.GetInfo();

            C2 obj2 = new("obj2");
            obj2.GetInfo();

            C2 obj3 = new("obj3", 21);
            obj3.GetInfo();
            
            C2 obj4 = new C2() { s1 = "obj4", i1 = 18 };
            obj4.GetInfo();
        }
    }
    class C2
    {
        public string s1;
        public int i1;
        public C2() { s1 = "undefind"; i1 = 0; }
        public C2(string s) { s1 = s; i1 = 0; }
        public C2(string s, int i)
        {
            this.s1 = s;
            this.i1 = i;
        }
        public void GetInfo()
        {
            Console.WriteLine($"s1: {s1}, i1: {i1}");
        }
    }
}