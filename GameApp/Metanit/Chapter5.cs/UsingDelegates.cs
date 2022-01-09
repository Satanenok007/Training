using System;

namespace UsingDelegates
{
    class C1
    {

        static void F1(string[] args)
        {
            C2 obj1 = new C2(1);
            C2.C3 colorDel = new C2.C3(Colormess);


            obj1.F2(new C2.C3(Showmess));
            obj1.F2(colorDel);

            obj1.F5(2);
            obj1.F5(3);

            obj1.F2(colorDel);
            obj1.F5(4);
        }
        private static void Showmess(String mess)
        {
            Console.WriteLine(mess);
        }
        private static void Colormess(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mess);
            Console.ResetColor();
        }
    }
    class C2
    {
        int _n1;

        public delegate void C3(string message);
        C3 _del1;

        public void F2(C3 del)
        {
            _del1 += del;
        }
        public void F3(C3 del)
        {
            _del1 -= del;
        }

        public C2(int sum)
        {
            _n1 = sum;
        }

        public int P1
        {
            get { return _n1; }
        }

        public void F4(int sum)
        {
            _n1 += sum;
        }

        public void F5(int sum)
        {
            if (sum <= _n1)
            {
                _n1 -= sum;

                if (_del1 != null)
                {
                    _del1($"- sum: {sum}");
                }
            }
            else
            {
                if (_del1 != null)
                {
                    _del1("Недостаточно денег на счете");
                }
            }
        }
    }
}