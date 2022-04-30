// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

int[] CreateArray(int count)  // Создаем массив
{
    int[] result = new int[8];
    return result;
}

void FillRandomAndPrintArray(int[] array) // Заполняем массив случайными числами от 0 до 9 и выводим на экран
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]} ");
    }
}

 int[] arr = CreateArray(8);
 FillRandomAndPrintArray(arr);
 
