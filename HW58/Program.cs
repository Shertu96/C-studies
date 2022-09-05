//Задать две матрицы. Находить произведение двух матриц.

using System;

namespace HW58
{
    class Program
    {
    
        static void Main()
        {
            int firstColumn = 3;
            int firstRow = 4;
            int secondColumn = firstRow;
            int secondRow = 5;

            int[,] arrayA = CreateDoubleArray(firstColumn, firstRow);
            int[,] arrayB = CreateDoubleArray(secondColumn, secondRow);

            // Multiplier       Умножение двумерных массивов
            // * CountPositionValue   Перемножать два одномерных массива 

            Console.WriteLine("\nПервый массив:");
            PrintArray(FillArray(arrayA));
            Console.WriteLine();

            Console.WriteLine("Второй массив:");
            PrintArray(FillArray(arrayB));
            Console.WriteLine();

            PrintArray(Multiplier(arrayA, arrayB));
        }

        static int[,] CreateDoubleArray(int column, int row)
        {
            return new int[column, row];
        }

        static int[,] FillArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return arr;
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] Multiplier(int[,] firstArray, int[,] secondArray)
        {
            int[,] multiplyArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    multiplyArray[i, j] = CountPositionValue(firstArray, secondArray, i, j);
                }
            }
            return multiplyArray;
        }

        static int CountPositionValue(int[,] firstArray, int[,] secondArray, int column, int row)
        {
            int sum = 0;

            for (int i = 0; i < firstArray.GetLength(1); i++)
            {
                sum += firstArray[column, i] * secondArray[i, row];
            }
            return sum;
        }
    }
}
