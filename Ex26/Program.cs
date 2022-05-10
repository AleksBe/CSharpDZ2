// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] CreateArray(int count)
{
    int[] result = new int[8];
    return result;
}

void FillArrayAndPrint(int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}
int[] arr = CreateArray(8);
FillArrayAndPrint(arr);
