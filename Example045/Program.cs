// 45. Показать числа Фибоначчи

// int a0 = 1;
// int a1 = 1;
// int a2 = a0 + a1;
// int a3 = a1 + a2;
// int a4 = a2 + a3;


int a0 = 65;

double[] array = new double[a0];
array[0] = 0;
array[1] = 1;

System.Console.WriteLine("0 - " + array[0]);
System.Console.WriteLine("1 - " + array[1]);
for (int i = 2; i < array.Length; i++)
{
    array[i] = array[i-1] + array[i-2];
    System.Console.WriteLine($"{i} - {array[i]}");
}