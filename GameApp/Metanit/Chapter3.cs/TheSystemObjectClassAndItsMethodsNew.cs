using System;

namespace TheSystemObjectClassAndItsMethod
{
    class C1
    {
        public string s1 { get; set; }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(s1))
            {
                return base.ToString();
            }
            return s1;
        }

        public override int GetHashCode()
        {
            return s1.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            C1 person = (C1)obj;
            return (this.s1 == person.s1);
        }

    }
    class Program
    {
        private static void MainTheSystemObjectClassAndItsMethods(string[] args)
        {
            C1 obj1 = new C1 { s1 = "o1" };
            Console.WriteLine(obj1.GetType());


            object obj2 = new C1 { s1 = "o2" };

            if (obj2.GetType() == typeof(C1))
            {
                Console.WriteLine("C1");
            }


            C1 obj3 = new C1 { s1 = "o3" };
            C1 obj4 = new C1 { s1 = "o4" };
            C1 obj5 = new C1 { s1 = "o5" };
            bool obj3Eobj2 = obj1.Equals(obj2);
            bool obj5Eobj3 = obj1.Equals(obj3);
        }
    }
}