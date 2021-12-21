using System;

namespace CreatingExceptionСlasses
{
    class C1
    {
        static void F1(string[] args)
        {
            try
            {
                C2 obj1 = new C2 { n1 = "1", N2 = 10 };
            }
            catch (C2Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.val}");
            }
        }
    }

    class C2
    {
        public string n1 { get; set; }
        private int n2;
        public int N2
        {
            get { return n2; }
            set
            {
                if (value < 21)
                {
                    throw new C2Exception("numb < 21", value);
                }
                else
                {
                    n2 = value;
                }
            }
        }
    }

    class C2Exception : ArgumentException
    {
        public int val { get; }
        public C2Exception(string mess, int val)
        : base(mess)
        {
            this.val = val;
        }
    }
}