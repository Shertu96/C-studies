// Принять на вход число и выдать сумму цифр в числе.

Console.WriteLine("Введите число:");
string? textNum = Console.ReadLine();
int sum = 0;

for (int i = 0; i < textNum.Length; i++)
{
    sum += (int)Char.GetNumericValue(textNum[i]); // Конвертация символа в число (другие способы не сработали)
}
Console.WriteLine($"Sum = {sum}");
