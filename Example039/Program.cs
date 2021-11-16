// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2, 5);
    System.Console.Write(array[i] + " ");
}

int j = array.Length - 1;

for (int i = 0; i < array.Length / 2; i++)
{
    int result = array[i] * array[j];
    System.Console.WriteLine();
    System.Console.Write(result);
    j--;
}