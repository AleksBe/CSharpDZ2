// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

// Решаем через создание метода для каждой подзадачи.

int[]CreateArray(int count)   // Создаем массив
{
    int[]result = new int[12];  // Пусть будет 12 элементов.
    return result;
}

void FillArray(int[] array)   // Заполняем массив случайными 3-х значными числами
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 100);          // пусть будет от 0 до 99
        Console.Write($"{array[i]} ");                // Выводим массив, чтобы можно было проверить результат
    }
}

int Result(int[] array)  // Считаем сумму элементов, стоящих на нечетных позициях
{
    int len = array.Length;
    int summ = 0;
    for(int i = 0; i < len; i++)
    {
        
        if(i % 2 != 0) 
        {
            summ = summ + array[i];
        }
    }
    return summ;
}

int[] arr = CreateArray(12);     // Собираем всё вместе
FillArray(arr);
Console.WriteLine();
int final = Result(arr);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {final}");