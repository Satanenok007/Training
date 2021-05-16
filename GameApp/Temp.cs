using System;

static class Temp
{
    public static void Run()
    {
        // int xLength = 15;
        // int yLength = 7;
        // char[,] m2 = new char[xLength, yLength];
        // int smilecoordinateX = 1;
        // int smilecoordinateY = 1;
        // int fruitcoordinateX = 0;
        // int fruitcoordinateY = 0;
        // Random rnd = new Random();
        // fruitcoordinateX = rnd.Next(1, xLength - 1);
        // fruitcoordinateY = rnd.Next(1, yLength - 1);
        // while (true)
        // {
        //     ConsoleKeyInfo key = Console.ReadKey();
        //     char symbol = key.KeyChar;

        //     Console.WriteLine("----------");

        //     if (symbol == 's')
        //     {
        //         if (smilecoordinateY < yLength - 2)
        //         {
        //             smilecoordinateY++;
        //         }
        //     }
        //     else if (symbol == 'w')
        //     {
        //         if (smilecoordinateY > 1)
        //         {
        //             smilecoordinateY--;
        //         }
        //     }
        //     else if (symbol == 'd')
        //     {
        //         if (smilecoordinateX < xLength - 2)
        //         {
        //             smilecoordinateX++;
        //         }
        //     }
        //     else if (symbol == 'a')
        //     {
        //         if (smilecoordinateX > 1)
        //         {
        //             smilecoordinateX--;
        //         }
        //     }

        //     if (smilecoordinateX == fruitcoordinateX && smilecoordinateY == fruitcoordinateY)
        //     {
        //         {
        //             if (fruitcoordinateX == smilecoordinateX && fruitcoordinateY == smilecoordinateY)
        //             {
        //                 fruitcoordinateX = rnd.Next(1, xLength - 1);
        //                 fruitcoordinateY = rnd.Next(1, yLength - 1);
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //     }

        //     for (int y = 0; y < yLength; y++)
        //     {
        //         for (int x = 0; x < xLength; x++)
        //         {
        //             if (y == 0 || y == yLength - 1)
        //             {
        //                 m2[x, y] = '1';
        //             }
        //             else if (x == 0 || x == xLength - 1)
        //             {
        //                 m2[x, y] = '1';
        //             }
        //             else
        //             {
        //                 m2[x, y] = '.';
        //             }
        //             if (y == smilecoordinateY && x == smilecoordinateX)
        //             {
        //                 m2[x, y] = 'w';
        //             }
        //             if (y == fruitcoordinateY && x == fruitcoordinateX)
        //             {
        //                 m2[x, y] = 'f';
        //             }
        //         }
        //     }

        //     for (int y = 0; y < yLength; y++)
        //     {
        //         for (int x = 0; x < xLength; x++)
        //         {
        //             Console.Write(m2[x, y]);
        //         }
        //         Console.WriteLine();
        //     }
        //     Console.WriteLine();
        // }

        // int m1Length = 10;
        // int m2Length = 10;
        // int[] m1 = new int[m1Length];
        // int[] m2 = new int[m2Length];
        // Random rnd = new Random();
        // // int x = 0;
        // for (int i = 0; i < m1Length; i++)
        // {
        //     m1[i] = rnd.Next(0, 10);
        //     m2[i] = m1[i];
        // }
        // for (int y = 0; y < m1Length; y++) {
        //     Console.Write(m1[y]);
        // }
        // Console.WriteLine("----------------------------------");
        // for(int z = 0; z < m2Length; z++) {
        //     Console.Write(m2[z]);
        // }
        // int m1Length = 10;
        // int[] m1 = new int[m1Length];
        // Random rnd = new Random();
        // int a = 0;
        // for (int i = 0; i < m1Length; i++)
        // {
        //     m1[i] = rnd.Next(0, 10);
        // }
        // for (int x = 0; x < m1Length; x++)
        //     for (int y = 0; y < m1Length; y++)
        //     {
        //         if (m1[x] < m1[y])
        //         {
        //             a = m1[x];
        //             m1[x] = m1[y];
        //             m1[y] = a;
        //         }
        //     }

        // for (int z = 0; z < m1Length; z++)
        // {
        //     Console.Write(m1[z]);
        // }

       
        // int xLength = 5;
        // int yLength = 5;
        // int kLength = 2;
        // char[,] m2 = new char[xLength, yLength];
        // char z = ' ';
        // char[] key = new char[kLength];
        // key[0] = '1';
        // key[1] = '0';
        // Random rnd = new Random();
        // for (int x = 0; x < xLength; x++)
        // {
        //     for (int y = 0; y < yLength; y++)
        //     {
        //         m2[x, y] = (rnd.Next(0, 2).ToString())[0];
        //     }
        // }

        // for (int x = 0; x < xLength; x++)
        // {
        //     for (int y = 0; y < yLength; y++)
        //     {
        //         Console.Write(m2[x, y]);
        //     }
        //     Console.WriteLine();
        // }


        // Console.WriteLine("wwwwww");

        // for (int y = 0; y < yLength; y++)
        // {
        //     for (int x = 0; x < xLength; x++)
        //     {
        //         if (x + 1 < xLength)
        //         {
        //             if (m2[x, y] == key[0] && m2[x + 1, y] == key[1])
        //             {
        //                 m2[x, y] = z;
        //                 m2[x + 1, y] = z;
        //             }
        //         }
        //         // Console.WriteLine(m2[x,y]);
        //     }
        //     //    Console.WriteLine();
        // }

        // for (int x = 0; x < xLength; x++)
        // {
        //     for (int y = 0; y < yLength; y++)
        //     {
        //         if (y + 1 < yLength)
        //         {
        //             if (m2[x, y] == key[0] && m2[x, y + 1] == key[1])
        //             {
        //                 m2[x, y] = z;
        //                 m2[x, y + 1] = z;
        //             }
        //         }
        //         // Console.WriteLine(m2[x,y]);
        //     }
        //     //    Console.WriteLine();
        // }

        // Console.WriteLine("yyyyyyyyyyy");

        // for (int x = 0; x < xLength; x++)
        // {
        //     for (int y = 0; y < yLength; y++)
        //     {
        //         Console.Write(m2[x, y]);
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine("rrrrrrrrr");


        // int xLength = 5;
        // int yLength = 5;
        // int kLength = 4;
        // char[,] m1 = new char[xLength, yLength];
        // char[,] m2 = new char[xLength, yLength];
        // char z = ' ';
        // char[] key = new char[kLength];
        // Random rnd = new Random();
        // for (int x = 0; x < xLength; x++)
        // {
        //     for (int y = 0; y < yLength; y++)
        //     {
        //         m1[x, y] = (rnd.Next(0, 2).ToString())[0];
        //         m2[x, y] = m1[x, y];
        //     }
        // }

        // for (int k = 0; k < kLength; k++)
        // {
        //     key[k] = (rnd.Next(0, 2).ToString())[0];
        // }

        // for (int x = 0; x < xLength; x++)
        // {
        //     for (int y = 0; y < yLength; y++)
        //     {
        //         Console.Write(m2[x, y]);
        //     }
        //     Console.WriteLine();
        // }

        // if (kLength < xLength)
        // {
        //     for (int x = 0; x < xLength - kLength; x++)
        //     {
        //         for (int y = 0; y < yLength; y++)
        //         {
        //             for (int r = 0; r < kLength; r++)
        //             {
        //                 if (m1[x + r, y] == key[r])
        //                 {
        //                     m2[x, y] = '1';
        //                 }
        //                 else
        //                 {
        //                     break;
        //                 }
        //             }
        //         }
        //     }
        // }
    }
}

