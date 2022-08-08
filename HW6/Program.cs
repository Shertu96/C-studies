// Проверить, чётное ли число ввёл пользователь

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber % 2 == 0) //проверка, делится ли число x нацело на число y - (x % y == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}