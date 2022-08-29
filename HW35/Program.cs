// Задать одномерный массив из 123 случайных чисел. 
// Найти количество элементов массива, значения которых лежат в отрезке [10,99].

class Program
{
    static void Main()
    {
        int[] array = CreateRandomArray();
        PrintArray(array);
        Console.WriteLine(Inside(array, 10, 99));
    }

    static int[] CreateRandomArray()
    {
        int[] array = new int[123];
        return FillArray(array);
    }

    static int[] FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 100);
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

    static int Inside(int[] array, int from, int to)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= from && array[i] <= to)
            {
                count++;
            }
        }
        return count;
    }
}
