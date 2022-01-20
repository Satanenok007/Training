using System;

namespace InterfaceInheritance
{
    class C1
    {
        static void F1()
        {
            I1 obj1 = new C2();
            obj1.F2();

            I2 obj2 = new C2();
            obj2.F2();
        }
    }

    interface I1
    {
        void F2() => Console.WriteLine("obj1");
    }
    interface I2 : I1
    {
        new void F2() => Console.WriteLine("obj2");
    }
    class C2 : I2
    {
        public void F2() => Console.WriteLine("obj3");
    }
}