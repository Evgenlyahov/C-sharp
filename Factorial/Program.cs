// Вычисление факториала числа
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}


void PrintFactorial(int factorialDigit)
{
    for (int i = 1; i < factorialDigit; i++)
    {
        System.Console.WriteLine($"{i}! = {Factorial(i)}");
    }
}
PrintFactorial(30);