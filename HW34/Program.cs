// Задать массив заполненный случайными положительными трёхзначными числами. Написать программу, которая покажет количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        int[] array = CreateRandomArray();
        PrintArray(array);
        Console.WriteLine(OddCounter(array));
    }

    static int[] CreateRandomArray()
    {
        int[] array = new int[new Random().Next(1, 10)]; // Слишком много элементов - долго выполняет
        return FillArray(array);
    }

    static int[] FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(100, 1000);
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static int OddCounter(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
