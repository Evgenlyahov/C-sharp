// 50. В двумерном массиве n×k заменить четные элементы на противоположные

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
        System.Console.WriteLine();
    }
}

int[,] ChangeEvenOnOpposite(int[,] twoDimensionalArray)
{
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            if(twoDimensionalArray[i, j] % 2 == 0)
            {
                twoDimensionalArray[i, j] = -twoDimensionalArray[i, j];
            }
        }
    }
    return twoDimensionalArray;
}

int[,] twoDimensionalArray = new int[4,5];
FillTwoDimensionalArray(twoDimensionalArray, 10, 31);
PrintTwoDimensionalArray(twoDimensionalArray);
ChangeEvenOnOpposite(twoDimensionalArray);
PrintTwoDimensionalArray(twoDimensionalArray);