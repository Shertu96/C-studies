// Some tips for working with arrays

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 75, 28, 40, 12, 93}; // Если массив известен
        // int[] numbers = new int[7]; ---- Если массив неизвестен, длина задана
        Console.WriteLine(numbers[0]); // Какой эл-т вывести
        int len = numbers.Length; // Узнать размер массива (количество считаем с 1)
        Console.WriteLine(numbers[numbers.Length - 1]); // Вывести последнее значение массива (индексы с 0)
    }
}
