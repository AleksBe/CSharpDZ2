// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[]CreateArray(int count)
{
    int[] result = new int[10];  // пусть массив будет из 10 элементов
    return result;
}

void FillArrayAndPrint(int[] array)
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
}

void Multiplication(int[] array)
{
    int len = array.Length;
    for(int i = 0; i < len/2; i++)
    {
        int mult = array[i] * array[(len-1)-i];
        Console.Write($"{mult} ");
    }
}

int[] arr = CreateArray(10);
FillArrayAndPrint(arr);
Console.WriteLine();
Multiplication(arr);