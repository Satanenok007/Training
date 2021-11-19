using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Property1 p1 = new Property1();
            p1.N1 = 123;
            int temp1 = p1.N1;
            Console.WriteLine(temp1);

            Property2 p2 = new Property2();
            int temp2 = p2.N2;
            Console.WriteLine(temp2);

            Property3 p3 = new Property3();
            p3.N3 = 1234;

            Property4 p4 = new Property4();
            p4.n4 = 1223;
            Console.WriteLine(p4.n5);

            Property5 p5 = new Property5();
            p5.N6 = 1234;
            p5.n7 = 1111;
            Console.WriteLine(p5.N6);
            Console.WriteLine(p5.n7);
        }
    }

    class Property1
    {
        private int n1;

        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                if (value > 0)
                {
                    n1 = value;
                }
            }
        }
    }
    class Property2
    {
        private int n2;

        public int N2
        {
            get
            {
                return n2;
            }
            private set
            {
                n2 = value;
            }
        }
    }

    class Property3
    {
        private int n3;
        public int N3
        {
            private get
            {
                return n3;
            }
            set
            {
                n3 = value;
            }
        }
    }

    class Property4
    {
        public int n4 { get; set; } = 1234;
        public int n5 { get; private set; }
    }

    class Property5
    {
        private int n6;
        public int n7 { get; set; } = 1111;

        public int N6
        {
            get
            {
                return n6;
            }
            set
            {
                if (value > 0)
                {
                    n6 = value;
                }
            }
        }
    }
}