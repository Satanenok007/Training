using System;

static class Key
{
    public static void Run()
    {
        int Length = 7;
        char[] OriginalArray = new char[Length];
        char[] CopyArray = new char[Length];
        int keyLength = 2;
        char[] key = new char[keyLength];
        char Space = ' ';
        Random rnd = new Random();
        for (int x = 0; x < Length; x++)
        {
            OriginalArray[x] = (rnd.Next(1, 5).ToString())[0];
            CopyArray[x] = OriginalArray[x];
        }

        for (int x = 0; x < Length; x++)
        {
            Console.Write(OriginalArray[x]);
        }

        Console.WriteLine();

        for (int y = 0; y < keyLength; y++)
        {
            key[y] = (rnd.Next(1, 5).ToString())[0];
        }

        for (int r = 0; r < keyLength; r++)
        {
            Console.Write(key[r]);
        }


        for (int x = 0; x < Length; x++)

        {
            for (int k = 0; k < keyLength; k++)
            {
                if (OriginalArray[x] == key[k])
                {
                    CopyArray[x] = Space;

                }
                continue;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < Length; i++)
        {
            Console.Write(CopyArray[i]);
        }
    }
}




// Console.WriteLine();
// Console.WriteLine();

// for (int x = 0; x < m1Length; x++)
// {
//     Console.Write(m1[x]);
// }