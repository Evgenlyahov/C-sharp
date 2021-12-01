// 56. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] FillTwoDimensionalArray(int[,] twoDimensionalArray, int leftBound, int rightBound)
{
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            twoDimensionalArray[i, j] = new Random().Next(leftBound, rightBound);
        }
    }
    return twoDimensionalArray;
}

void PrintTwoDimensionalArray(int[,] twoDimensionalArray)
{
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            System.Console.Write(twoDimensionalArray[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] CopyTwoDimensionalArray(int[,] twoDimensionalArray)
{
    int[,] copyTwoDimensionalArray = new int[twoDimensionalArray.GetLength(0), twoDimensionalArray.GetLength(1)];
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            copyTwoDimensionalArray[i, j] = twoDimensionalArray[i, j];
        }
    }
    return copyTwoDimensionalArray;
}

int[,] ChangeRowInTwoDimensionalArray(int[,] originalTwoDimensionalArray, int[,] copyTwoDimensionalArray)
{
    int firstRow = 0;
    int lastRow = originalTwoDimensionalArray.GetLength(0) - 1;
    for (int i = 0; i < originalTwoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < originalTwoDimensionalArray.GetLength(1); j++)
        {
            if (i == firstRow) copyTwoDimensionalArray[lastRow, j] = originalTwoDimensionalArray[i, j];
            if (i == lastRow) copyTwoDimensionalArray[firstRow, j] = originalTwoDimensionalArray[i, j];
        }
    }
    return copyTwoDimensionalArray;
}

int[,] twoDimensionalArray = new int[3, 3];
FillTwoDimensionalArray(twoDimensionalArray, 10, 21);
// PrintTwoDimensionalArray(twoDimensionalArray);
System.Console.WriteLine();
int[,] copyTwoDimensionalArray = CopyTwoDimensionalArray(twoDimensionalArray);
PrintTwoDimensionalArray(copyTwoDimensionalArray);
System.Console.WriteLine();

ChangeRowInTwoDimensionalArray(twoDimensionalArray, copyTwoDimensionalArray);
PrintTwoDimensionalArray(ChangeRowInTwoDimensionalArray(twoDimensionalArray, copyTwoDimensionalArray));
