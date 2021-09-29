using System;

namespace DefiningInterfaces
{
    public interface IMovable
    {
        public const int minSpeed = 0;
        public static int maxSpeed = 60;
        public void Move()
        {
            Console.WriteLine("Walking");
        }
        int MaxSpeed { get { return 0; } }
        static int MaxSpeeds
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }
        static double GetTime(double distance, double speed) => distance / speed;
        protected internal string Name { get; set; }
        public delegate void MoveHandler(string message);
        public event MoveHandler MoveEvent;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IMovable.MaxSpeeds);
            IMovable.MaxSpeeds = 65;
            Console.WriteLine(IMovable.MaxSpeeds);
            double time = IMovable.GetTime(100, 10);
            Console.WriteLine(time);
        }
    }
}