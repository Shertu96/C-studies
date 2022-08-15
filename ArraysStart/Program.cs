// Поиск маскимального из 9 чисел

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
array[0] = 12; // Обратились и заменили
Console.WriteLine(array[0]); // Обратились к массиву, получили и вывели значение

int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if(arg2 > max) 
    {
        max = arg2;
    }
    if(arg3 > max) 
    {
        max = arg3;
    }
    return max;
}

int outcome = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(outcome);
