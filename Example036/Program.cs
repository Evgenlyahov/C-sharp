// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write(array[i] + " ");
    }
}

void CountEvenOdd(int[] array)
{
    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            countEven++;
        }
        if (array[i] % 2 != 0)
        {
            countOdd++;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(countEven);
    System.Console.WriteLine(countOdd);
}
int[] arr = new int[30];
FillArray(arr);
CountEvenOdd(arr);