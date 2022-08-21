//  Принять на вход число (N) и выдать таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = 0;

for (int N = Convert.ToInt32(Console.ReadLine()); number < N; number++)
{
    Console.WriteLine(Math.Pow(number,3));
}

