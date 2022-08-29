// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое числo: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе числo: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Число A в степени B равно: " + Pow2(a, b));
Console.WriteLine();

int Pow(int number, int degree)
{
    int newNum = 1; // Любое число в степени 0 = 1
    for(int i = 0; i < degree; i++)
    {
        newNum *= number;
    }
    return newNum;
}

double Pow2(int number, int degree)
{
    switch (degree)
    {
        case 1:
            return number;
        case 0:
            return 1;
        case < 0:
            return 1.0 / Pow2(number, -degree);
        default:
            return number * Pow2(number, degree - 1);
    }
}
