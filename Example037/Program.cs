// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
        System.Console.Write(array[i] + " ");
    }
}

int[] array = new int[123];
FillArray(array);

void FindRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        count++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Число совпавших элементов - {count}");
}

FindRange(array);