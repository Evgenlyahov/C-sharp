// 24. Найти кубы чисел от 1 до N

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

int[] array = FillArray(15);
PrintArray(array);
System.Console.WriteLine();

void FofCube(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int result = array[i]*array[i]*array[i];
        System.Console.WriteLine(result + " ");
    }
}
FofCube(array);