// 35. Определить, присутствует ли в заданном массиве, некоторое число 

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        System.Console.Write($"{array[i]} ");
    }
}

int[] array = new int[10];

void FindDigit(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        bool a;
        if (find == array[i])
        {
            a = true;
            System.Console.WriteLine($"Элемент {i} совпадает с искомым числом {find} ");
        }
        else
        {
            a = false;
        }
    }

}

FillArray(array, 10, 16);
System.Console.WriteLine();
FindDigit(array, 11);