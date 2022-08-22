// Задать массив из N элементов и вывести их на экран

int number = Convert.ToInt32(Console.ReadLine()); // Задаётся длина массива, последующие введенные цифры - элементы
int[] array = new int[number];

for(int i = 0; i < number; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("[");
for(int i = 0; i < number; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");