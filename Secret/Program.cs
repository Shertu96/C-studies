int SecretNumber = new Random().Next(1,11);
int attempts = 3;
bool flagWin = false;
while(attempts > 0)
{
    Console.WriteLine("Введите число от 1 до 10");
    string str = Console.ReadLine();
    int UserNumber = 0;
    if(str == "1" || str == "2" || str == "3" || str == "4" || str == "5" || str == "6" || str == "7" || str == "8" || str == "9" || str == "10") //проверка типа данных, можно проще, пока не знаю, как именно
    {
        UserNumber = Convert.ToInt32(str);
    }
    else
    {
        break;
    }
    attempts--;
    if(UserNumber > SecretNumber)
    {
        Console.WriteLine("Секретное число меньше");
        Console.WriteLine("Попыток осталось: " + attempts);
    }
    else if(UserNumber < SecretNumber)
    {
        Console.WriteLine("Секретное число больше");
        Console.WriteLine("Попыток осталось: " + attempts); 
    }
    else 
    {
        Console.WriteLine("Вы угадали!");
        flagWin = true;
        break;
    }
}
if(!flagWin)
{
    Console.WriteLine("Вы проиграли, число было: " + SecretNumber);
}