// 41. Выяснить являются ли три числа сторонами треугольника 
// int a = 10;
// int b = 11;
// int c = 20;

// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// bool isTriangle(int a, int b, int c)
// {
//     if ((a + b) > c && (a + c) > b && (b + c) > a)
//     {
//         return true;
//     }
//     return false;
// }


// System.Console.WriteLine(isTriangle(10, 13, 14));


bool isTriangle(int firstSide, int secondSide, int thirdSide)
{
    if((firstSide + secondSide) > thirdSide && (firstSide + thirdSide) > secondSide && (secondSide + thirdSide) > firstSide)
    {
        return true;
    }
    return false;
}

int firstSide = 10;
int secondSide = 10;
int thirdSide = 20;
bool result = isTriangle(firstSide, secondSide,thirdSide);
System.Console.WriteLine(result);
if(result == true) 
{
    System.Console.WriteLine("Может быть треуголником");
}
else
{
    System.Console.WriteLine("Не может быть треугольником");
}