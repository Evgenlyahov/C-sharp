﻿Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 390;

int a2 = 12;
int b2 = 230;
int c2 = 33;

int a3 = 13;
int b3 = 22;
int c3 = 3300;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
//Можно так
int max = Max(max1, max2, max3);
//А можно так
int max_max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine("Первый вариант");
Console.WriteLine(max);
Console.WriteLine("Второй вариант");
Console.WriteLine(max_max);