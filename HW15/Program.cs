// Принять на вход цифру, обозначающую день недели, и проверить, выходной ли это день.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели (цифру от 1 до 7): ");
        string? day = Console.ReadLine();
        Console.WriteLine(usersDay(day));
    }

    static string usersDay(string? day)
    {
        if (day == "6" || day == "7")
        {
            return "День выходной";
        }
        return "День будний";
    }
}
