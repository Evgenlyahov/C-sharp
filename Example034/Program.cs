// 34. Написать программу замену элементов массива на противоположные

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        System.Console.Write(array[i] + " ");
    }
}

int[] array = new int[10];
FillArray(array);


void ReplaceDigit(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
        System.Console.Write(array[i] + " ");
    }
}
System.Console.WriteLine();
ReplaceDigit(array);