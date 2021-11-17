// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
        System.Console.Write(array[i] + " ");
    }
}
float MaxElement(float[] array)
{
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
float MinElement(float[] array)
{
    float min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

float[] arr = new float[10];
FillArray(arr);

float resultMax = MaxElement(arr);
float resultMin = MinElement(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальный элемент: {resultMax}");
System.Console.WriteLine($"Минимальный элемент: {resultMin}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами равна {resultMax - resultMin}");