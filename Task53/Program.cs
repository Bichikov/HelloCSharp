// Task 53.

// Задайте двумерный массив. 
// Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
            
        }
            Console.WriteLine("|");
    }
}

void ChangeArray(int[,] matrix) // Замена первой и посоедней строки.
{
    int temp = 0;
    int first = 0;
    int last = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        temp = matrix[first, j];
        matrix[first, j] = matrix[last, j];
        matrix[last, j] = temp;
    }
        
    }

Console.Clear();

int[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2D);

Console.WriteLine();

Console.WriteLine("Замена местами первой строки и последней: ");
Console.WriteLine();

ChangeArray(array2D); // Замена массива и после печать 
PrintMatrix(array2D);






