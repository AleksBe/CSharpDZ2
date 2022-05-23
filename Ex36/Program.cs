// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

int m = 3;  // Задаем количество строк
int n = 5;  // Задаем количество столбцов
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

void SelectionSort(int[,] matr)
{
    for(int i = 0; i < m; i ++)
    {
        for(int j = 0; j < n; j ++)
        {
            int maxPosition = j;
            for(int k = j + 1; k < n; k ++)
            {
                if(matr[i, k] > matr[i, maxPosition])
                {
                    int temporary = matr[i, k];
                    matr[i, k] = matr[i, maxPosition];
                    matr[i, maxPosition] = temporary;
                   
                }
                
            }
            
        }  
       
    }
}
Console.WriteLine("Исходный массив: ");
FillArray(matr);
PrintArray(matr);
Console.WriteLine("Упорядоченный массив: ");
SelectionSort(matr);
PrintArray(matr);
