// Найти произведение пар чисел в одномерном массиве.  
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.  
// Результат записать в новом массиве.

class Program
{
    static void Main()
    {
        int[] array = CreateRandomArray();
        PrintArray(array);
        PrintArray(Multiply(array));
    }

    static int[] CreateRandomArray()
    {
        int[] array = new int[3];
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

    static int[] Multiply(int[] array)
    {
        int[] newArray = new int[array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1];
        if (array.Length % 2 == 1)
        {
            newArray[newArray.Length - 1] = array[newArray.Length - 1];
        }
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - (i + 1)];
        }
        return newArray;
    }
}


// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат записать в новом массиве.
/*
class Program
{
    static void Main()
    {
        int[] array = CreateRandomArray();
        PrintArray(array);
        PrintArray(Multiply(array));
    }

    static int[] CreateRandomArray()
    {
        int[] array = new int[3];
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

    static int[] Multiply(int[] array)
    {
        int[] newArray = new int[array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length - (i + 1)]; // i + 1 потому что индекс с нуля, а Length даст длину (с 1)
        }

        // TODO Костыль - исправить!
        if (array.Length % 2 == 0)
        {
            return newArray;
        }
        newArray[newArray.Length - 1] = array[newArray.Length - 1];
        return newArray;
    }
}
*/
