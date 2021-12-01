// 54 В матрице чисел найти сумму элементов главной диагонали

void FillArray(int[,] doubleArray, int leftBound, int rightBound)
{

    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i, j] = new Random().Next(leftBound, rightBound);
        }
    }
}

void PrintArray(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            System.Console.Write(doubleArray[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

// int SummDiagonal(int[,] doubleArray)
// {
//     int summDiagonal = doubleArray[0, 0];
//     for (int i = 1; i < doubleArray.GetLength(0); i++)
//     {
//         for (int j = 1; j < doubleArray.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 summDiagonal = summDiagonal + doubleArray[i, j];
//             }
//         }
//     }
//     return summDiagonal;
// }


int SummDiagonal(int[,] doubleArray)
{
    int summDiagonal = doubleArray[0, 0];
    for (int i = 1; i < doubleArray.GetLength(0); i++)
    {
        summDiagonal = summDiagonal + doubleArray[i, i];
    }
    return summDiagonal;
}

int[,] doubleArray = new int[7, 7];

FillArray(doubleArray, 10, 20);
PrintArray(doubleArray);

int summArray = SummDiagonal(doubleArray);
System.Console.WriteLine($"Сумма диагонали = {summArray}");