// 1. Заполнить двумерный массив размером n*m случайными числами
// 2. Напечатать двумерный массив на экран
// 3. Найти наибольший элемент двумерного массива
// 4. Найти сумму элементов двумерного массива

// void FillArray(int[,] doubleArray, int leftBound, int rightBound)
// {

//     for(int i = 0; i < doubleArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < doubleArray.GetLength(1); j++)
//         {
//             doubleArray[i,j] = new Random().Next(leftBound, rightBound);
//         }

//     }

// }

// void PrintArray(int[,] doubleArray)
// {
//     for(int i = 0; i < doubleArray.GetLength(0); i++)
//     {
//         for( int j = 0; j < doubleArray.GetLength(1); j++)
//         {
//             System.Console.Write(doubleArray[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }


// int LargestElement(int[,] doubleArray)
// {
//     int max = doubleArray[0,0];
//     for(int i = 0; i < doubleArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < doubleArray.GetLength(1); j++)
//         {
//             if(doubleArray[i,j] > max)
//             {
//                 max = doubleArray[i,j];
//             }

//         }

//     }
//     return max;
// }


// int SumAll(int[,] doubleArray)
// {
//     int sumAll = 0;
//     for (int i = 0; i < doubleArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < doubleArray.GetLength(1); j++)
//         {
//             sumAll = sumAll + doubleArray[i,j];
//         }
//     }
//     return sumAll;
// }



// int[,] doubleArray = new int[2,4];
// FillArray(doubleArray, 10, 50);
// PrintArray(doubleArray);
// int largestElement = LargestElement(doubleArray);
// System.Console.WriteLine($"Максимальное значение двумерного массива = {largestElement}");

// int sumAll = SumAll(doubleArray);
// System.Console.WriteLine($"Сумма массива равна = {sumAll}");





// 54 В матрице чисел найти сумму элементов главной диагонали
// 55 Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// 56 Написать программу, которая обменивает элементы первой строки и последней строки

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