// See https://aka.ms/new-console-template for more information
int[] LotoArray(int size, int leftBound, int rightBound)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftBound, rightBound);
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] ArrayLoto = LotoArray(8, 1, 21);
System.Console.WriteLine();
int[] ArrayLoto2 = LotoArray(1, 1, 5);
PrintArray(ArrayLoto);
System.Console.WriteLine();
PrintArray(ArrayLoto2);
System.Console.WriteLine();


Console.WriteLine("Ура, я выиграл!");
