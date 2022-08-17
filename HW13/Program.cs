// Вывести 3-й знак заданного числа или сообщить, что 3-его знака нет (для двузначных чисел и цифр)

class Program
{
    static void Main(string[] args)
    {
        // 1st method
        Console.WriteLine("Введите Ваше число: ");
        // 2nd method 
        string? userNumber = Console.ReadLine();
        Console.WriteLine(ThirdChar(userNumber));
    }

    static string ThirdChar(string? userNumber)
    {
        if (userNumber?.Length > 2)
        {
            return $"Третий знак - {userNumber[2]}";
        }
        return "Третьего знака нет!";
    }
}
