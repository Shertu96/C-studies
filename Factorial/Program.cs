// Факториал через рекурсию

double Factorial (int n) // Тип int переполянется на 17, надо заменить на double 
{
    if(n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

Console.WriteLine(Factorial(40));

for(int i = 1; i < 40; i++) // Проверка работы алгоритма, вывод всех чисел ДО искомого
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
