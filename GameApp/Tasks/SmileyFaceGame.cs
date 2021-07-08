using System;
public static class SmileyFaceGame
{
    public static void Run()
    {
        int verticalLength = 10;
        int horizontalLength = 10;
        char[,] field = new char[verticalLength, horizontalLength];

        Function.CreatingAnArrayWithBarriersAndASmileyFace(field, verticalLength, horizontalLength);
    }
}