// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] CreateArray(int count)
{
    int[] result = new int[123];
    return result;
}

void FillArrayAndPrint(int[] array)
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 250);
        Console.Write($"{array[i]} ");
    }
}

int Counting(int[]array)
{
    int len = array.Length;
    int count = 0;
    for(int i = 0; i < len; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count = count + 1;
    }
    return count;
}

int[] arr = CreateArray(123);
FillArrayAndPrint(arr);
int total = Counting(arr);
Console.WriteLine($"Количество элементов в отрезке от 10 до 99: {total}");
