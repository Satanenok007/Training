using System;
namespace UsingDelegates
{
    class C1
    {
        static void F1()
        {
            C2 obj1 = new C2(100);
            obj1.RegisterDel(Messege);
            obj1.AddNumb(10);
            obj1.DeleteNumb(50);
            obj1.DeleteNumb(70);

            void Messege(string mess) => Console.WriteLine(mess);
        }
    }

    public delegate void del1(string mess);

    class C2
    {
        int n1;
        del1? delete;
        public C2(int n1) => this.n1 = n1;

        public void RegisterDel(del1 d1)
        {
            delete = d1;
        }
        public void AddNumb(int n1) => this.n1 += n1;
        public void DeleteNumb(int n1)
        {
            if (this.n1 >= n1)
            {
                this.n1 -= n1;
                delete?.Invoke($"- {n1}");
            }
            else
            {
                delete?.Invoke($"the subtracted number is greater than the available one. Number: {this.n1}");
            }
        }
    }
}