// Числа Фибоначчи

int Fibonacci(int n)
{
    if(n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

for(int i = 1; i < 17; i++) // Число можно задать любое, после 40 начнет работать медленно из-за зтрат ресурсов
{
    Console.WriteLine(Fibonacci(i));
}
