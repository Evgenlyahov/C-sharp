// 43. Написать программу преобразования десятичного числа в двоичное

// int ToBinary(int d) // Рассмотрим на примере d = 5
// {
//     int b = 0;
//     int c = 1;
//     while (d > 0)       // d = 5          d = 2        d = 1       d = 0
//     {
//         if (d % 2 == 1) // d%2 == 1       d%2 == 0     d%2 == 1
//         {
//             b = b + c;  // b = 1          -----        b = 101
//         }
//         d = d / 2;      // d = 2          d = 1        d = 0
//         c = c * 10;     // c = 10         c = 100      c = 1000
//     }
//     return b; // b = 101
// }

int BinarySystem(int decimalDigit)
{
    int binaryDigit = 0;
    int binaryOne = 1;
    while (decimalDigit > 0)
    {
        if (decimalDigit % 2 == 1)
        {
            binaryDigit = binaryDigit + binaryOne;
        }
        binaryOne = binaryOne * 10;
        decimalDigit = decimalDigit / 2;
    }
    return binaryDigit;
}

int binaryDigit = BinarySystem(18);
System.Console.WriteLine(binaryDigit);



