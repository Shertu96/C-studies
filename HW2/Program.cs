// Сравниваем 2 числа, которые вводит пользователь:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число");
int userNumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int userNumberB = Convert.ToInt32(Console.ReadLine());

int max = userNumberA;

if (userNumberB > max)
    max = userNumberB;

Console.Write("Максимальное число: ");
Console.WriteLine(max);
