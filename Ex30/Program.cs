// Составить частотный словарь элементов двумерного массива
// Будем считать для двумерного массива чисел
// Сначала будем выводить массив, потом считать количество цифр

int[,] matrix = new int[5, 5];  // Пусть будет 5 строк и 5 столбцов

void FillArrayAndPrint(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }  
}
    
void Result(int[,] matrix)
{
    int count0 = 0;
    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    int count4 = 0;
    int count5 = 0;
    int count6 = 0;
    int count7 = 0;
    int count8 = 0;
    int count9 = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == 0) count0 = count0 + 1;
            if(matrix[i, j] == 1) count1 = count1 + 1;
            if(matrix[i, j] == 2) count2 = count2 + 1;
            if(matrix[i, j] == 3) count3 = count3 + 1;
            if(matrix[i, j] == 4) count4 = count4 + 1;
            if(matrix[i, j] == 5) count5 = count5 + 1;
            if(matrix[i, j] == 6) count6 = count6 + 1;
            if(matrix[i, j] == 7) count7 = count7 + 1;
            if(matrix[i, j] == 0) count8 = count8 + 1;
            if(matrix[i, j] == 0) count9 = count9 + 1;
        }
    }
            Console.WriteLine($"Количество чисел '0' в массиве: {count0}");
            Console.WriteLine($"Количество чисел '1' в массиве: {count1}");
            Console.WriteLine($"Количество чисел '2' в массиве: {count2}");
            Console.WriteLine($"Количество чисел '3' в массиве: {count3}");
            Console.WriteLine($"Количество чисел '4' в массиве: {count4}");
            Console.WriteLine($"Количество чисел '5' в массиве: {count5}");
            Console.WriteLine($"Количество чисел '6' в массиве: {count6}");
            Console.WriteLine($"Количество чисел '7' в массиве: {count7}");
            Console.WriteLine($"Количество чисел '8' в массиве: {count8}");
            Console.WriteLine($"Количество чисел '9' в массиве: {count9}");         
}


FillArrayAndPrint(matrix);
Console.WriteLine();
Result(matrix);
