// Пользователь вводит число, программа показывает все чётные числа до него.

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

for(int Number = 1; Number <= userNumber; Number++)
if(Number % 2 == 0)
   {
    Console.WriteLine(Number);
   } 