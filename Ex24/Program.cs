// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[]CreateArray(int count)   // Создаем массив
{
    double[]result = new double[10];  // Пусть будет 10 элементов.
    return result;
}

void FillArray(double[] array)   // Заполняем массив случайными 3-х значными числами
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(-10, 11);          // пусть будет от -10 до 10
        Console.Write($"{array[i]} ");                // Выводим массив, чтобы можно было проверить результат
    }
}

double Maximum(double[] array)  // Определяем максимальный элемент массива
{
    int len = array.Length;
    double max = array[0];
    for(int i = 0; i < len; i++)
    {
        if(array[i] > max) 
        {
            max = array[i];
        }
    }
    return max;
}

double Minimum(double[] array)  // Определяем минимальный элемент массива
{
    int len = array.Length;
    double min = array[0];
    for(int i = 0; i < len; i++)
    {
        if(array[i] < min) 
        {
            min = array[i];
        }
    }
    return min;
}


double[] arr = CreateArray(10);     // Собираем всё вместе
FillArray(arr);
Console.WriteLine();
double Maxx = Maximum(arr);
Console.WriteLine($"Максимальный элемент массива = {Maxx}");
double Minn = Minimum(arr);
Console.WriteLine($"Минимальный элемент массива = {Minn}");
double diff = Maxx - Minn;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");
