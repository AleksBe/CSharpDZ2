// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// Если наименьший элемент встречается несколько раз, будем удалять столбец и строку где он встречается впервые.
int m = 7; // Здесь будем задавать число строк массива
int n = 7; // Здесь будем задавать число столбцов массива
int[,] matr = new int[m, n];

void FillMatrAndPrint(int[,] matr)
    {
        for(int i = 0; i < matr.GetLength(0); i ++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

int FindMin(int[,] matr)
{
            int matrmin = matr[0, 0];
            int imin = 0;
            int jmin = 0;
       
    for(int i = 0; i < matr.GetLength(0); i ++)
    {
        for(int j = 0; j < matr.GetLength(1); j ++)
        {
            if(matr[i, j] < matrmin)
            {
                matrmin = matr[i, j];
                imin = i;
                jmin = j;   
            }            
        }   
    }
    return matrmin;    
}

int FindMinRow(int[,] matr)
{
            int matrmin = matr[0, 0];
            int imin = 0;
            int jmin = 0;
       
    for(int i = 0; i < matr.GetLength(0); i ++)
    {
        for(int j = 0; j < matr.GetLength(1); j ++)
        { 
            if(matr[i, j] < matrmin)
            {
                matrmin = matr[i, j];
                imin = i;
                jmin = j;   
            }              
        }   
    }
    return imin;    
}

int FindMinColumn(int[,] matr)
{
            int matrmin = matr[0, 0];
            int imin = 0;
            int jmin = 0;
       
    for(int i = 0; i < matr.GetLength(0); i ++)
    {
        for(int j = 0; j < matr.GetLength(1); j ++)
        {
            if(matr[i, j] < matrmin)
            {
                matrmin = matr[i, j];
                imin = i;
                jmin = j;   
            }             
        }   
    }
    return jmin;
}

void NewArray(int[,] matr, int row, int column)
{
    string[,] matr1 = new string [m, n];
    for(int i = 0; i < matr.GetLength(0); i ++)
    {
        for(int j = 0; j < matr.GetLength(1); j ++)
        {
            matr1[i, j] = Convert.ToString(matr[i, j]);
            matr1[i, column] = string.Empty;
            matr1[row, j] = string.Empty;
            Console.Write($"{matr1[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Исходная матрица:");
FillMatrAndPrint(matr);
int min = FindMin(matr);
int row = FindMinRow(matr);
int column = FindMinColumn(matr);
Console.WriteLine($"Наименьший элемент массива= {min}, строка: {row}, столбец: {column}");
Console.WriteLine($"Будем удалять строку: {row}, столбец: {column}");
Console.WriteLine("Новая матрица:");
NewArray(matr, row, column);
