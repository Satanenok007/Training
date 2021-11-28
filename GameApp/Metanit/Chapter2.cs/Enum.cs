using System;

namespace Enum
{
    class C1
    {
        static void Main()
        {
            Colours(Colour.Green);
            Colours(Colour.Yellow);
            Colours(Colour.Pink);

            void Colours(Colour colour)
            {
                switch (colour)
                {
                    case Colour.Green:
                        Console.WriteLine("green");
                        break;
                    case Colour.Red:
                        Console.WriteLine("red");
                        break;
                    case Colour.Yellow:
                        Console.WriteLine("yellow");
                        break;
                    case Colour.Gray:
                        Console.WriteLine("grey");
                        break;
                    case Colour.Pink:
                        Console.WriteLine("pink");
                        break;
                }
            }
        }
    }
}
enum Colour
{
    Green,
    Red,
    Yellow,
    Gray,
    Pink
}