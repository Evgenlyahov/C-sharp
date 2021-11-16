// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
        System.Console.Write($"Элемент {i}: {array[i]}, ");
    }
}

int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;

FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}

System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных - {sumPositive} ");
System.Console.WriteLine($"Сумма отрицательных - {sumNegative} ");