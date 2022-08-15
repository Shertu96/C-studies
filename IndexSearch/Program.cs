// Searching Index

int[] array = {34, 19, 1, 17, 48, 81, 5, 17};

int n = array.Length; // Количество элементов массива
int find = 17; // Искомый эл-т; если таких несколько, то покажет все индексы, если в цикле не будет "break;"

int index = 0;

while (index < n)
{
    if (array[index] == find) // Совпадает
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}
