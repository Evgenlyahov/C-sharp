// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
double[] DotOfCross(double k1, double b1, double k2, double b2)
{
    double[] A = { 0, 0 };
    if (k1 == k2 && b1 == b2)
    {
        A[1] = b1;
        System.Console.WriteLine("Прямые совпадают.");
        return A;
    }
    if (k1 == k2 && b1 != b2)
    {
        System.Console.WriteLine("Прямые параллельны.");
        return A;
    }
    A[0] = (b2 - b1) / (k1 - k2);
    A[1] = A[0] * k1 + b1;
    return A;
}

void PrintArrayDouble(double[] A)
{
    int L = A.Length;
    for (int i = 0; i < L; i++)
    {
        Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}

double[] B = DotOfCross(2, 99, 2, 99);
System.Console.Write("Точка пересечения - ");
PrintArrayDouble(B);