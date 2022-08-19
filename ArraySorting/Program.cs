// Упорядочить данные внутри массива методом выбора (от минимального к максимальному).

int[] arr = {5, 2, 1, 6, 8, 20, 7, 2, 23, 3, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); // Вывели массив
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++) // На лекции было (array.Length - 1), но так первый эл-т встает в конец
        {
            if (array[j] < array[minPosition])
            {
            minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        Console.Write($"{array[i]} "); // Вывели массив
    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);
