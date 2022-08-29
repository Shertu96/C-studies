// Двумерные массивы

string[,] table = new string[5, 8]; // по умолчанию String.Empty

for(int rows = 0; rows < 5; rows++)
{
    for(int columns = 0; columns < 8; columns++)
    {
        Console.Write($"{table[rows, columns]}");
    }
    Console.WriteLine(); // Разрыв для аккуратности вывода
}


int[,] matrix = new int [3,4]; // По умолчанию заполняется 0
matrix[1,2] = 15; // обратились к элементу и изменили его

for(int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for(int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"{matrix[rows, columns]}");
    }
    Console.WriteLine();
}


int[,] array = new int[4,7];
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
