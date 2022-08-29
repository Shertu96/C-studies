// Числа Фибоначчи

int Fibonacci(int n)
{
    /*
    if(n == 0)
    {
        return 0;
    }
    if(n == 1 || n == 2)
    {
        return 1;
    }
    */
    if (n == 0 || n == 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for(int i = 0; i < 17; i++) // Число можно задать любое, после 40 начнет работать медленно из-за затрат ресурсов
{
    Console.WriteLine(Fibonacci(i));
}
