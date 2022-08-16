// Принять трёхзначное число, вывести 2й знак

void FillArray(int[] numbers) // Рассматриваем число как массив - создаем и заполняем массив
{
    int length = numbers.Length;
    int index = 0;
    while(index < length)
    {
        numbers[index] = new Random().Next(1,9);
        index++;
    }
}

void PrintArray(int[] nums)
{
    int count = nums.Length;
    int ind = 0;
    while(ind < count)
    {
        Console.Write(nums[ind]);
        ind++;
    }
}


int[] array = new int[3]; 

FillArray(array);
PrintArray(array);

Console.WriteLine(":");
Console.WriteLine(array[1]);
