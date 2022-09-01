// Принять на вход позиции элемента в двумерном массиве, вернуть значение этого элемента.
// Или указать, что такого элемента нет.

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0,100);
        }
    }
}

FillArray(array);

Console.WriteLine ("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row > m || column > n) 
{
    Console.WriteLine ("Такого элемента нет!");
}
else
{
    Console.WriteLine ("Элемент массива: " + array[row,column]);
}
