// 23. Показать таблицу квадратов чисел от 1 до N


int[] FillArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
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

int[] array = FillArray(100);
PrintArray(array);
System.Console.WriteLine();
void PrintArrayTable(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int result = array[i] * array[i];
        if (array[i] == 11 || array[i] == 21 || array[i] == 31 || array[i] == 41 || array[i] == 51 || array[i] == 61 || array[i] == 71 || array[i] == 81 || array[i] == 91)
        {
            System.Console.WriteLine();
        }
        System.Console.WriteLine($"{array[i]} * {array[i]} = {result}");
    }
}
PrintArrayTable(array);