// Задать двумерный массив. Упорядочить по убыванию элементы каждой строки двумерного массива.

using System;

namespace HW54
{
    class Program
    {
    
        static void Main()
        {
            int column = 4;
            int row = column;

            int[,] array = new int[column, row];

            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintArray(SelectionSort(array));
        }

        static void FillArray(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 100);
                }
            }
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] SelectionSort(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] < array[i, k])
                        {
                            int stack = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = stack;
                        }
                    }
                }
            }
            return array;
        }
    }
}
