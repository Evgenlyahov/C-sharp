// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

double[] AverageOfColumnsTwoDimensionalArray(int[,] twoDimensionalArray)
{
    double sumColumn1 = 0;
    double sumColumn2 = 0;
    double sumColumn3 = 0;
    double sumColumn4 = 0;
    double sumColumn5 = 0;
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            if (j == 0) sumColumn1 = sumColumn1 + twoDimensionalArray[i, j];
            if (j == 1) sumColumn2 = sumColumn2 + twoDimensionalArray[i, j];
            if (j == 2) sumColumn3 = sumColumn3 + twoDimensionalArray[i, j];
            if (j == 3) sumColumn4 = sumColumn4 + twoDimensionalArray[i, j];
            if (j == 4) sumColumn5 = sumColumn5 + twoDimensionalArray[i, j];
        }
    }
    double[] sumOfColumns = new double[5] { sumColumn1, sumColumn2, sumColumn3, sumColumn4, sumColumn5 };
    double[] averageColumns = new double[sumOfColumns.Length];
    for (int g = 0; g < sumOfColumns.Length; g++)
    {
        averageColumns[g] = sumOfColumns[g] / sumOfColumns.Length;
    }
    return averageColumns;
}

void PrintResultArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Среднеее арифметическое {i} столбца - " + array[i]);
    }
}

int[,] twoDimensionalArray = new int[5, 5];
FillTwoDimensionalArray(twoDimensionalArray, 10, 21);
PrintTwoDimensionalArray(twoDimensionalArray);
double[] SumOfColumnss = AverageOfColumnsTwoDimensionalArray(twoDimensionalArray);
System.Console.WriteLine();
PrintResultArray(SumOfColumnss);