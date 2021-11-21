// fibonacci(0) = 0
// fibonacci(1) = 1
// fibonacci(2) = fibonacci(1) + fibonacci(0) = 1 + 0 = 1
// fibonacci(3) = fibonacci(2) + fibonacci(1) = 1 + 1 = 2
// fibonacci(n) = fibonacci(n-1) + fibonacci(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 2) + Fibonacci(n - 1);
}


void PrintFibonacci(int n)
{
    for (int i = 1; i < n; i++)
    {
        System.Console.WriteLine($"{i} - {Fibonacci(i)}");
    }
}

PrintFibonacci(45);