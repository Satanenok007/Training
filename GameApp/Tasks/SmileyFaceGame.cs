using System;
public static class SmileyFaceGame
{
    public static void Run()
    {
        int verticalLength = 10;
        int horizontalLength = 10;
        char[,] field = new char[verticalLength, horizontalLength];
        char[,] copyField = Function.CreatingAField(field, verticalLength, horizontalLength);
        // Function.PrintTwoDimensionalCharArray(copyField, verticalLength, horizontalLength);
        Function.CreatingAndPromotingASmileyFace(verticalLength, horizontalLength);
        Function.CopyingAnArrayWithBarriersAndASmileyFace(field, verticalLength, horizontalLength);
        // Function.PrintTwoDimensionalCharArray(copyField, verticalLength, horizontalLength);
    }
}