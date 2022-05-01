// Задать массив заполненный случайными положительными трехзначными числами. 
//Написать программу, которая покажет количество четных чисел в массиве.

// Решаем через создание метода для каждой подзадачи.

int[]CreateArray(int count)   // Создаем массив
{
    int[]result = new int[10];  // Пусть будет 10 элементов.
    return result;
}

void FillArray(int[] array)   // Заполняем массив случайными 3-х значными числами
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");                // Выводим массив, чтобы можно было проверить результат
    }
}

int Result(int[] array)  // Считаем количество четных элементов
{
    int len = array.Length;
    int count = 0;
    for(int i = 0; i < len; i++)
    {
        
        if(array[i] % 2 == 0) 
        {
            count = count + 1;
        }
    }
    return count;
}

int[] arr = CreateArray(10);     // Собираем всё вместе
FillArray(arr);
Console.WriteLine();
int final = Result(arr);
Console.WriteLine($"Количество четных чисел в массиве {final}");