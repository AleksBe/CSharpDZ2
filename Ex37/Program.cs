// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = 5;  // Задаем количество строк
int n = 7;  // Задаем количество столбцов
int[,] matr = new int[m, n];

void FillArray(int[,] matr)
{
    for(int i = 0; i < m; i ++)
    {
        for(int j = 0; j < n; j ++)
        {
            matr[i, j] = new Random().Next(0, 10);
        } 
    }
}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < m; i ++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindSumm(int[,] matr)
{
        int minRowNumber = 0;
        int[] sum = new int[m];
        for(int i = 0; i < m; i ++)
        {
            for(int j = 0; j < n; j ++)
            {
                {
                 sum[i] = sum[i] + matr[i, j];
                }      
            } 
         Console.WriteLine($"Сумма элементов i = {i} строки = {sum[i]}");
         
            int minRow = sum[0];
         
            if(sum[i] <= minRow)
            { 
            minRow = sum[i];
            minRowNumber = i;
            }
        }
        Console.WriteLine($"Индекс строки с наименьшей суммой элементов: i = {minRowNumber}");
}

FillArray(matr);
PrintArray(matr);
FindSumm(matr);