// Определить, присутствует ли в заданном массиве, некоторое число.

int[]CreateArray(int count)
{
    int[]result = new int[20];
    return result;
}

int random = new Random().Next(0, 10);
Console.WriteLine($"Будем искать число: {random}");

void FillArrayAndPrint(int[]array)
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 51);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Desigion(int[] array)
{
    int len = array.Length;
    int count = 0;
    for(int i = 0; i < len; i++)
    {
        if(array[i] == random) count = count + 1;
    }
    if(count > 0)
    { 
        Console.WriteLine($"Число {random} встречается в массиве {count} раз");
    }
    else
    {
        Console.WriteLine($"Число {random} в массиве не встречается");
    }
}

int[] arr = CreateArray(20);
FillArrayAndPrint(arr);
Desigion(arr);
