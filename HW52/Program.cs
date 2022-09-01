// Задать двумерный массив из целых чисел. Найти среднее арифметическое элементов в каждом столбце.

int m = 4;
int n = 5;

int[,] array = new int[m,n];
void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

double ArithmeticMean(int column ) // Среднее арифметическое
{
    double count = 0;
    double average = 0;
    for (int i = 0; i < m; i++)
    {
        count += array [i, column];
    }
    average = count / m;
    return average;
}

double result = 0;
for (int j = 0; j < n; j++)
{
    result = ArithmeticMean(j);
    Console.WriteLine("Среднее арифметическое столбца: " + result);

}
