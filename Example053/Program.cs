// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

float[,] FillTwoDimensionalArray(float[,] twoDimensionalArray)
{
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            twoDimensionalArray[i, j] = new Random().Next(1, 11);
        }
    }
    return twoDimensionalArray;
}

void PrintTwoDimensionalArray(float[,] twoDimensionalArray)
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

void SearchOfFindInDimensionalArray(float[,] twoDimensionalArray, float findDigit)
{
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            if(twoDimensionalArray[i, j] == findDigit)
            {
                System.Console.WriteLine($"Элемент массива {twoDimensionalArray[i, j]} с индексом {i},{j} совпадает с {findDigit}");
                break;
            }
            else
            {
                System.Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}

float[,] twoDimensionalArray = new float[3, 3];
FillTwoDimensionalArray(twoDimensionalArray);
PrintTwoDimensionalArray(twoDimensionalArray);
SearchOfFindInDimensionalArray(twoDimensionalArray, 5);