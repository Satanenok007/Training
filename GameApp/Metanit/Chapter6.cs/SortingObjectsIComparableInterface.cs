using System;

namespace SortingObjectsIComparableInterface
{
    class C1
    {
        static void F1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            var obj1 = new C2("obj1", 1);
            var obj2 = new C2("obj2", 1);
            var obj3 = new C2("obj3", 1);

            C2[] obj4 = { obj1, obj2, obj3 };
            Array.Sort(obj4);

            foreach (C2 o4 in obj4)
            {
                Console.WriteLine($"{o4.S1} - {o4.N1}");
            }

            var obj5 = new C5("obj5", 5);
            var obj6 = new C5("obj6", 6);
            var onj7 = new C5("obj7", 7);
        }
    }

    public interface I1
    {
        int F2(object? o);
    }

    class C2 : I1
    {
        public string S1 { get; }
        public int N1 { get; set; }
        public C2(string s1, int n1)
        {
            S1 = s1; N1 = n1;
        }
        public int F2(object? o)
        {
            if (o is C2 c2) return S1.CompareTo(c2.S1);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }

    public interface I2<in T>
    {
        int F3(T? x, T? y);
    }

    class C4 : I2<C5>
    {
        public int F3(C5? p1, C5? p2)
        {
            if (p1 is null || p2 is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }
            return p1.S2.Length - p2.S2.Length;
        }
    }

    class C5
    {
        public string S2 { get; }
        public int N2 { get; set; }
        public C5(string s2, int n2)
        {
            S2 = s2; N2 = n2;
        }
    }
}