// 30. Показать кубы чисел, заканчивающихся на четную цифру

int[] createArray(int size, int min, int max)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max);
    }
    return numbers;
}

int[] arr = createArray(10, 5, 16);


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(2, 10);
//         System.Console.Write(array[i] + " ");
//     }
// }

// void CubeOdd(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int cubeElement;
//         cubeElement = array[i] * array[i] * array[i];
//         if(cubeElement % 2 == 0)
//         {
//             System.Console.WriteLine();
//             System.Console.WriteLine($"Куб {array[i]} оканчивается на чётную цифру и равен {cubeElement}");
//         }
//     }
// }

// int[] array = new int[10];
// FillArray(array);
// CubeOdd(array);