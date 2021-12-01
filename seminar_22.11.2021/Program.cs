// Вернуть массив определённой длины, заполненный случайными числами.

int[] CreateArray(int size, int leftBound, int rightBound)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftBound, rightBound);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] array = CreateArray(20, -10, 11);
PrintArray(array);

int FindIndexByValue(int[] array, int find)
{
    int searchIndex = -1;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] == find)
        {
            searchIndex = i;
        }
    }
    return searchIndex;
}
System.Console.WriteLine();
int searchElement = FindIndexByValue(array, 7);
System.Console.WriteLine(searchElement);

int CountNegativeArray(int[] array)
{
    int count = 0;
    int[] negativeArray = new int[] { };
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < 0)
        {
            count++;
        }
    }
    return count;
}

int[] CreateNegativeArray(int[] array, int size)
{
    int[] negativeArray = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        negativeArray[i] = array[i];
    }
    return negativeArray;
}

int size = CountNegativeArray(array);
CreateNegativeArray(array, size);
PrintArray(array);

int a = CountNegativeArray(array);
System.Console.WriteLine();
System.Console.WriteLine(a);




// int[,] TurnTuQuarter(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] % 2 == 0)
//             {
//                 array [i, j] = array [i, j]*array [i, j];
//             }
//         }

//     }
//     return array;

// }
// int[,] array = {{1, 2, 3},{4, 5, 6}};
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// PrintArray(array);
// array = TurnTuQuarter(array);
// PrintArray(array);
