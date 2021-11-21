// 21. Программа проверяет пятизначное число на палиндром.

// Проверить число на палиндром
// Вариант 1

// string isPalindrom = "12321";

// int d = isPalindrom.Length;

// int b = Convert.ToInt32(isPalindrom);
// System.Console.WriteLine(b);
// System.Console.WriteLine(d);

// if(isPalindrom[0] == isPalindrom[4] && isPalindrom[1] == isPalindrom[3])
// {
//     System.Console.WriteLine(isPalindrom + " - палиндром");
// }
// else
// {
//     System.Console.WriteLine(isPalindrom + " - не палиндром");
// }


// Вариант 2

// int isPalindrom = 1034321;

// int a0 = isPalindrom / 1000000;
// int a1 = isPalindrom / 100000 % 10;
// int a2 = isPalindrom % 100000 / 10000;
// int a3 = isPalindrom % 10000 / 1000;
// int a4 = isPalindrom % 1000 / 100;
// int a5 = isPalindrom % 100 / 10;
// int a6 = isPalindrom % 10;
// if (a0 == a6 && a1 == a5 && a2 == a4)
// {
//     System.Console.WriteLine($"{isPalindrom} - палиндром");
// }
// else System.Console.WriteLine($"{isPalindrom} - не палиндром");
// System.Console.Write(a0);
// System.Console.Write(a1);
// System.Console.Write(a2);
// System.Console.Write(a3);
// System.Console.Write(a4);
// System.Console.Write(a5);
// System.Console.Write(a6);



// Вариант 3
string isPalindrom = "12321";

for (int i = 0; i < isPalindrom.Length / 2; i++)
{
    if (isPalindrom[i] == isPalindrom[isPalindrom.Length - 1 - i] && isPalindrom[i + 1] == isPalindrom[isPalindrom.Length - 1 - 1])
    {
        System.Console.WriteLine($"Число {isPalindrom} - палиндром");
        break;
    }
    else System.Console.WriteLine($"Число {isPalindrom} - не палиндром");
    break;
}