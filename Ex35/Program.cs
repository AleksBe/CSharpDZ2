// Спирально заполнить двумерный массив.
// Программу будем писать для массива 4 х 4.

int m = 4; // Задаем количество строк
int n = 4; // Задаем количество столбцов
int[,]a = new int[m, n];

void FillArray(int[,]a)
{
    a[0, 0] = 1; // Начинать будем с 1
    // Пошел первый контур
    for(int i = 0; i < 1; i ++)
    {
        for(int j = 1; j < n; j ++)
        { 
            a[i, j] = a[i, (j - 1)] + 1;     
        } 
    }
    for(int i = 1; i < m; i ++)
    {
        for(int j = n - 1; j >= n - 1; j --)
        {
            a[i, j] = a[(i - 1), j] + 1;
        }       
    }
    for(int i = m - 1; i > m - 2; i --)
    {
        for(int j = (n - 2); j >= 0; j --)
        {
            a[i, j] = a[i, (j + 1)] + 1;   
        }
    }   
    for(int i = m - 2; i > 0; i --)
    {
        for(int j = 0; j < 1; j ++)
        {
            a[i, j] = a[(i + 1), j] + 1;  
        }     
    }
    // Пошел второй контур 
    for(int i = 1; i < 2; i ++)
    { 
        for(int j = 1; j < (n - 1); j ++)
        {
           a[i, j] = a[i, (j - 1)] + 1;  
        }
    }   
    for(int i = 2; i < (m - 1); i ++)
    {
        for(int j = n - 2; j > n - 3; j --)
        {
           a[i, j] = a[(i - 1), j] + 1;      
        }  
    }    
    for(int i = m - 2; i > m - 3; i --)
    {  
        for(int j = n - 3; j > 0; j --)
        {
            a[i, j] = a[i, (j + 1)] + 1;  
        }
    }
              
}
    void PrintArray(int[,]a)
    {
        for(int i = 0; i < m; i ++)
        {
            Console.WriteLine();
            for(int j = 0; j < n; j ++)
            {
            Console.Write($"{a[i, j]} ");
            }    
        }   
    }

FillArray(a);
PrintArray(a);


