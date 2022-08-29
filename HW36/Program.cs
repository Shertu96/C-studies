// Задать одномерный массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечётных позициях.

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
        int[] array = new int[new Random().Next(1, 10)];
        return FillArray(array);
    }

    static int[] FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 10);
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
            if (i % 2 == 1)
            {
                count += array[i];
            }
        }
        return count;
    }
}
