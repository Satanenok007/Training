using System;

namespace ExplicitImplementationOfInterfaces
{
    class C1
    {
        static void F1(string[] args)
        {
            C2 obj1 = new C2();
            ((I1)obj1).F2();
            ((I2)obj1).F2();

            C4 obj2 = new C4();
            obj2.F3();
            ((I3)obj2).F3();

            C3 obj3 = new C3();
            obj3.F3();
        }
    }

    class C2 : I1, I2
    {
        void I1.F2() => Console.WriteLine("n1");
        void I2.F2() => Console.WriteLine("n2");
    }

    interface I1
    {
        void F2();
    }
    interface I2
    {
        void F2();
    }

    interface I3
    {
        void F3();
    }

    class C3 : I3
    {
        public void F3() => Console.WriteLine("n3");
    }

    class C4 : C3, I3
    {
        void I3.F3() => Console.WriteLine("n4");
    }
}