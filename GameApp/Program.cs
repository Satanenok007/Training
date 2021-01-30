using System;

int xLength = 15;
int yLength = 7;
char[,] m2 = new char[xLength, yLength];
int smilecoordinateX = 1;
int smilecoordinateY = 1;
int fruitcoordinateX = 0;
int fruitcoordinateY = 0;
Random rnd = new Random();
fruitcoordinateX = rnd.Next(1, xLength - 1);
fruitcoordinateY = rnd.Next(1, yLength - 1);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    char symbol = key.KeyChar;

    Console.WriteLine("----------");

    if (symbol == 's')
    {
        if (smilecoordinateY < yLength - 2)
        {
            smilecoordinateY++;
        }
    }
    else if (symbol == 'w')
    {
        if (smilecoordinateY > 1)
        {
            smilecoordinateY--;
        }
    }
    else if (symbol == 'd')
    {
        if (smilecoordinateX < xLength - 2)
        {
            smilecoordinateX++;
        }
    }
    else if (symbol == 'a')
    {
        if (smilecoordinateX > 1)
        {
            smilecoordinateX--;
        }
    }

    if (smilecoordinateX == fruitcoordinateX && smilecoordinateY == fruitcoordinateY)
    {
        {
            if (fruitcoordinateX == smilecoordinateX && fruitcoordinateY == smilecoordinateY)
            {
                fruitcoordinateX = rnd.Next(1, xLength - 1);
                fruitcoordinateY = rnd.Next(1, yLength - 1);
            }
            else
            {
                break;
            }
        }
    }

    for (int y = 0; y < yLength; y++)
    {
        for (int x = 0; x < xLength; x++)
        {
            if (y == 0 || y == yLength - 1)
            {
                m2[x, y] = '1';
            }
            else if (x == 0 || x == xLength - 1)
            {
                m2[x, y] = '1';
            }
            else
            {
                m2[x, y] = '.';
            }
            if (y == smilecoordinateY && x == smilecoordinateX)
            {
                m2[x, y] = 'w';
            }
            if (y == fruitcoordinateY && x == fruitcoordinateX)
            {
                m2[x, y] = 'f';
            }
        }
    }

    for (int y = 0; y < yLength; y++)
    {
        for (int x = 0; x < xLength; x++)
        {
            Console.Write(m2[x, y]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}