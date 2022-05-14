// Найти произведение двух матриц

int[,] matrA = new int[3, 3];
int[,] matrB = new int[3, 3];
int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];

void FillArrayAndPrintMatrA(int[,] matrA)
{
    for(int i = 0; i < matrA.GetLength(0); i++)
    {
        for(int j = 0; j < matrA.GetLength(1); j++)
        {
            matrA[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrA[i, j]} ");
        }
        Console.WriteLine();
    }  
}

void FillArrayAndPrintMatrB(int[,] matrB)
{
    for(int i = 0; i < matrB.GetLength(0); i++)
    {
        for(int j = 0; j < matrB.GetLength(1); j++)
        {
            matrB[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrB[i, j]} ");
        }
        Console.WriteLine();
    }  
}

void MultiplicationAndPrintC(int[,] matrA, int[,] matrB)
{
    for(int i = 0; i < matrA.GetLength(0); i++)
    {
        for(int j = 0; j < matrB.GetLength(1); j++)
        {
            matrC[i, j] = 0;
            for(int k = 0; k < matrA.GetLength(1); k++) 
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        Console.Write($"{matrC[i, j]} ");
    
        } 
        Console.WriteLine();  
    }
}

Console.WriteLine("Матрица А:");
FillArrayAndPrintMatrA(matrA);
Console.WriteLine("Матрица B:");
FillArrayAndPrintMatrB(matrB);
Console.WriteLine("Матрица C = Матрица А * Матрица В:");
MultiplicationAndPrintC(matrA, matrB);