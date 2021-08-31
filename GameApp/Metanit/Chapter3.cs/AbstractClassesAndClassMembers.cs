using System;

namespace AbstractClassesAndClassMembers
{
    abstract class Moves
    {
        public string Name { get; set; }
        public Moves(string name)
        {
            Name = name;
        }
        public abstract void Info();
    }

    class Series : Moves
    {
        public int NumberOfEpisodes { get; set; }
        public Series(string name, int numberOfEpisodes)
         : base(name)
        {
            NumberOfEpisodes = numberOfEpisodes;
        }
        public override void Info()
        {
            Console.WriteLine($"Название: {Name}, количество серий: {NumberOfEpisodes}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series("Firefly", 14);
            series.Info();
        }
    }
}