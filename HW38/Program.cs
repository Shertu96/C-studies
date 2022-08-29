// Задать массив вещественных чисел. Найnb разницу между максимальным и минимальным элементов массива.

class HW38
{
    static void Main()
    {
        double[] array = CreateRandomArray();
        PrintArray(array);
        Console.WriteLine(DiffMaxMin(array));
    }

    static double[] CreateRandomArray()
    {
        double[] array = new double[new Random().Next(1, 10)];
        return FillArray(array);
    }

    static double[] FillArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 100) + new Random().NextDouble();
        }
        return arr;
    }

    static void PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
           Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static double DiffMaxMin(double[] array)
    {
        return array.Max() - array.Min();
    }

}
