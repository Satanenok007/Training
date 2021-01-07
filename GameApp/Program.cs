using System;

// Console.Write("Enter Length: ");
// int length = int.Parse(Console.ReadLine());

// Console.Write('\u263A');
// Console.Write('\n');

// char ch1 = '\u263A';
// Console.WriteLine(ch1);

// char[] m1 = new char[length];
// for (int i = 0; i < m1.Length; i++)
// {
//     m1[i] = '\u263A';
//     Console.WriteLine(m1[i]);
// }

// Console.WriteLine("GameApp.");

const int width = 10;
const int heigth = 5;
int y = 0;
char[] m1 = new char[width * heigth];

for (int i = 0; i < m1.Length; i++)
{
    if (i < width)
    {
        m1[i] = '1';
    }
    else if (i >= m1.Length - width)
    {
        m1[i] = '1';
    }
    else if (i % width == 0) 
    {
        m1[i] = '1';
    }
    else if ((i + 1) % width == 0)
    {
        m1[i] = '1';
    }
    else
    {
        m1[i] = '0';
    }
}

for (int x = 0; x < m1.Length; x++)
{
    Console.Write(m1[x]);
    y++;

    if (y == width)
    {
        Console.WriteLine();
        y = 0;
    }
}
