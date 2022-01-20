using System;

namespace ImplementationOfInterfacesInBaseAndDerivedClasses
{
    class C1
    {
        static void F1()
        {
            I2 obj1 = new C5();
            obj1.F3();


            Option1 obj2 = new Opt1();
            obj2.F4();

            I3 obj3 = new Opt1();
            obj3.F4();


            Option2 obj4 = new Opt2();
            obj4.F5();

            I4 obj5 = new Opt2();
            obj5.F5();


            Option3 obj6 = new Opt3();
            obj6.F6();

            I5 obj7 = new Opt3();
            obj7.F6();
            
            Opt3 obj8 = new Opt3();
            obj8.F6();
        }
    }
    interface I1
    {
        void F2();
    }
    abstract class C2 : I1
    {
        public abstract void F2();
    }
    class C3 : C2
    {
        public override void F2() => Console.WriteLine("n1");
    }

    interface I2
    {
        void F3();
    }
    class C4
    {
        public void F3() => Console.WriteLine("n2");
    }

    class C5 : C4, I2 { }

    interface I3
    {
        void F4();
    }

    class Option1 : I3
    {
        public virtual void F4() => Console.WriteLine("Option1");
    }
    class Opt1 : Option1
    {
        public override void F4() => Console.WriteLine("Opt1");
    }

    interface I4
    {
        void F5();
    }

    class Option2 : I4
    {
        public void F5() => Console.WriteLine("Option2");
    }

    class Opt2 : Option2
    {
        public new void F5() => Console.WriteLine("Opt2");
    }


    interface I5
    {
        void F6();
    }

    class Option3 : I5
    {
        public void F6() => Console.WriteLine("Option3");
    }

    class Opt3 : Option3, I5
    {
        public new void F6() => Console.WriteLine("Opt3");
        void I5.F6() => Console.WriteLine("Op3");
    }
}