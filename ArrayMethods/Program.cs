// Создать и заполнить случайный массив, вывести его, найти индекс элемента

void FillArray(int[] collection) // Создали и заполнили
{
    int length = collection.Length; // Задали длину
    int index = 0; // По умолчанию
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Вывели в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

/* Для проверки работы методов:

int[] array = new int[10]; // Определили массив из 10-ти эл-тов

FillArray(array);
PrintArray(array);*/ 


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если в консоли выведет -1, значит, эл-т не найден (избегаем путаницы с эл-том[0])
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // Выведет первый индекс, если искомых эл-тов несколько
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Заполнит числами от 1 до 10 

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 8); // Ищем элемент "8"
Console.WriteLine(pos);
