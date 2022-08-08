//Для нескольких особенных пользователей

Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Маша" || username == "Илья" || username == "Анна")
{
    Console.WriteLine("Ура, это же особенный пользователь " + username + "!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
