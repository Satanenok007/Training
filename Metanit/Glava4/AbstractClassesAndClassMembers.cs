using System;

namespace AbstractClassesAndClassMembers
{
    class A
    {
        static void F1()
        {
            B obj1 = new B();
            obj1.F2();

            B obj2 = new I();
            obj2.F2();

            B obj3 = new C();
            obj3.F2();
            
            B obj4 = new D();
            obj4.F2();
        }
    }

    abstract class B
    {
        public abstract void F2();
    }

    class C : B
    {
        public override void F2()
        {
            Console.WriteLine("C");
        }
    }
    class D : B
    {
        public override void F2()
        {
            Console.WriteLine("D");
        }
    }
    class I : B
    {
        public override void F2()
        {
            Console.WriteLine("I");
        }
    }
}