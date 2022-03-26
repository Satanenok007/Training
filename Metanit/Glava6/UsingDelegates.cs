using System;

namespace UsingDelegates
{
    class C1
    {
        static void F1()
        {
            C2 obj1 = new C2(200);
            obj1.RegisterDel(Mess);
            obj1.AddNumber(200);
            obj1.DeleteNumber(300);
            obj1.DeleteNumber(150);
            void Mess(string mess) => Console.WriteLine(mess);
        }
    }

    public delegate void del2(string mess);
    class C2
    {
        int n2;
        del2? delete;
        public C2(int n2) => this.n2 = n2;
        public void RegisterDel(del2 del2)
        {
            delete = del2;
        }
        public void AddNumber(int n2) => this.n2 += n2;
        public void DeleteNumber(int n2)
        {
            if (this.n2 >= n2)
            {
                this.n2 += n2;
                delete?.Invoke($"subtracted {n2}");
            }
            else
            {
                delete?.Invoke($"the subtracted number is greater than the available one. Number {this.n2}");
            }
        }
    }
}