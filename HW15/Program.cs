// Принять на вход цифру, обозначающую день недели, и проверить, выходной ли это день.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели (цифру от 1 до 7): ");
        string? day = Console.ReadLine();
        userDayCheck(day);
        //Console.WriteLine(usersDay(day));
    }

    static string usersDay(string? day)
    {
        if (day == "6" || day == "7")
        {
            return "День выходной";
        }
        return "День будний";
    }

    static void userDayCheck(string? day)
    {
        int dayInt = Int32.Parse(day);
        switch (dayInt)
        {
            case >= 1 and <= 5:
                Console.WriteLine("Будний день!");
                break;
            case >= 1 and <= 7:
                Console.WriteLine("Выходной день!");
                break;
            default:
                Console.WriteLine("Введите цифру от 1 до 7");
                break;
        }
    }
}
