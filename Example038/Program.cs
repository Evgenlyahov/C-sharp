// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2, 11);
        System.Console.Write($"{array[i]} ");
    }
}

int SumOdd(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumOdd += array[i];
        }
    }
    return sumOdd;
}

int[] arr = new int[10];
FillArray(arr);
System.Console.WriteLine();
int sumOddProg = SumOdd(arr);
System.Console.WriteLine(sumOddProg);