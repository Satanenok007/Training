using System;
namespace Inheritance
{
    class A
    {
        public string s1 { get; set; }
        public A(string s1)
        {
            this.s1 = s1;
        }
        public void F2()
        {
            Console.WriteLine(s1);
        }
    }

    class B : A
    {
        public string s2 { get; set; }
        public B(string s1, string s2)
        : base(s1)
        {
            this.s2 = s2;
        }
    }
}