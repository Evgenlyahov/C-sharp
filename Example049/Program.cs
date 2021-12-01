// 49. Показать двумерный массив размером m×n заполненный вещественными числами
// Доэкспериментировался до 3-х мерного массива

float[,,] FillArrayDouble(float[,,] arrayDouble)
{
    for (int i = 0; i < arrayDouble.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            for (int g = 0; g < arrayDouble.GetLength(2); g++)
            {
                arrayDouble[i, j, g] = new Random().Next(1, 11);
            }
        }
    }
    return arrayDouble;
}

void PrintArrayDouble(float[,,] arrayDouble)
{
    for (int i = 0; i < arrayDouble.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            for (int g = 0; g < arrayDouble.GetLength(2); g++)
            {
                System.Console.Write(arrayDouble[i, j, g] + " ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

float[,,] arrayDoubleResult = new float[3, 2, 10];
FillArrayDouble(arrayDoubleResult);
PrintArrayDouble(arrayDoubleResult);

arrayDoubleResult[0, 0, 0] = 333.987645f;
arrayDoubleResult[1, 0, 0] = 555.99f;
arrayDoubleResult[2, 1, 9] = 1000.8f;
PrintArrayDouble(arrayDoubleResult);