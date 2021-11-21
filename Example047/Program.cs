// 47. Написать программу копирования массива

int[] FillArray(int countArray, int minRange, int maxRange)
{
    int[] array = new int[countArray];
    for (int i = 0; i < countArray; i++)
    {
        array[i] = new Random().Next(minRange, maxRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Элемент {i} - {array[i]}; ");
    }
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] array = FillArray(8, 1, 11);
PrintArray(array);
array[0] = 15;
System.Console.WriteLine();
int[] copyArray = CopyArray(array);
PrintArray(copyArray);