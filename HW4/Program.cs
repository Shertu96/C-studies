// Найти маскимальное из трёх чисел, которые вводит пользователь
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
int userNumA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int userNumB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int userNumC = Convert.ToInt32(Console.ReadLine());

int max = userNumA;

if(userNumB > max)
{
    max = userNumB;
}
else if(userNumC > max)
{
    max = userNumC;
}

Console.WriteLine("Максимальное число: " + max);