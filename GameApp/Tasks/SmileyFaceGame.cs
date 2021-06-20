using System;
public static class SmileyFaceGame
{
    public static void Run()
    {
        int verticalLength = 15;
        int horizontalLength = 15;
        char[,] field = new char[verticalLength, horizontalLength];
        char[,] copyField = Function.CreatingAField(field, verticalLength, horizontalLength);
        Function.PrintTwoDimensionalCharArray(copyField, verticalLength, horizontalLength);
    }
}