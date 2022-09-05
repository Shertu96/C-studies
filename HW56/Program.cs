// Задать прямоугольный двумерный массив. Находить строку с наименьшей суммой элементов.



using System;

namespace HW56
{
    class Program
    {
    
        static void Main()
        {
            int column = 5;
            int row = 6;

            int[,] array = CreateDoubleArray(column, row);
            PrintArray(FillArray(array));
            Console.WriteLine();
            Console.WriteLine(MinSumOfLine(array));
        }

        static int[,] CreateDoubleArray(int column, int row)
        {
            return new int[column, row];
        }

        static int[,] FillArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 100);
                }
            }
            return arr;
        }

        static void PrintArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static int MinSumOfLine(int[,] array)
        {
            int minLine = 0;
            int minSumOfLine = SumOfLine(array);

            Console.WriteLine(minSumOfLine);

            for (int i = 1; i < array.GetLength(0); i++)
            {
                int sumOfLine = SumOfLine(array, i);

                Console.WriteLine(sumOfLine);

                if (sumOfLine < minSumOfLine)
                {
                    minLine = i;
                    minSumOfLine = sumOfLine;
                }
            }
            Console.WriteLine();
            return minLine;
        }

        static int SumOfLine(int[,] array, int column = 0)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[column, i];
            }

            return sum;
        }
    }
}
