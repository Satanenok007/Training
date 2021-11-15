using System;

namespace CreatingExceptionClasses
{
    class C1
    {
        static void F1(string[] args)
        {
            try
            {
                C2 p1 = new C2 { N2 = "Sofia", N1 = 16 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
    class C2
    {
        private int n1;
        public string N2 { get; set; }
        public int N1
        {
            get { return n1; }
            set
            {
                if (value < 18)
                {
                    throw new Exception($"Лицам до 18 регистрация запрещена {value}");
                }
                else
                {
                    n1 = value;
                }
            }
        }
    }
}