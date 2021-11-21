// 42. Определить сколько чисел больше 0 введено с клавиатуры
System.Console.WriteLine("Введите 5 чисел");
System.Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int thirdDigit = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите четвёртое числ: ");
int fourthDigit = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите пятое число: ");
int fifthDigit = Convert.ToInt32(Console.ReadLine());

int[] array = { firstDigit, secondDigit, thirdDigit, fourthDigit, fifthDigit };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();

int AboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int count = AboveZero(array);
System.Console.WriteLine($"Количество цифр больше 0 - {count}");