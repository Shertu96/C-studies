// Принять пятизначное число и проверить, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string? userNumber = Console.ReadLine();

if(userNumber!.Length == 5)
{
    Check();
}

else
{
    Console.WriteLine("Число должно состоять из пяти знаков: ");
}


    void Check()
    {
        if(userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
        {
            Console.WriteLine("Число - палиндром!");
        }
    
        else
        {
            Console. WriteLine("Число не является палиндромом!");
        }
    }
