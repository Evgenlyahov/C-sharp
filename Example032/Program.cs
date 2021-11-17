// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void FillArray(int[] array)
{
    for (byte i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        System.Console.Write(array[i] + " ");
    }
}
int[] array = new int[8];
FillArray(array);