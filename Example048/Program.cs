// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] FillArrayDouble(int[,] arrayDouble)
{

    for (int i = 0; i < arrayDouble.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            arrayDouble[i, j] = new Random().Next(1, 11);
        }
    }
    return arrayDouble;
}

void PrintArrayDouble(int[,] arrayDouble)
{
    for (int i = 0; i < arrayDouble.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            System.Console.Write(arrayDouble[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    
}

int[,] arrayDouble = new int[3,6];
FillArrayDouble(arrayDouble);
PrintArrayDouble(arrayDouble);