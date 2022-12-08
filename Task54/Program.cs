// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixSorted(int[,] matrix)
{
  for (int k = 0; k < matrix.Length; k++) // тут мы пишеи всю длину массива потому что нам надо проверить каждый элемент массива.
  {
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0 ; j < matrix.GetLength(1)-1; j++) // (-1) -  потому что если дойдем до последнего элмента и '-1' не будет , то выдаст ошибку так как дальше мы задаепм условие j+1, а такого элемента нету.
        {
            if (matrix[i,j] < matrix[i,j+1]) //сортировка по убыванию
            {
                int t = matrix[i,j+1];
                matrix[i,j+1] = matrix[i,j];
                matrix[i,j] = t;
            }
        }
    }
  }
}

int[,] array2D = CreateMatrixRndInt(3, 5, 1, 10);
PrintMatrix(array2D);
MatrixSorted(array2D);
Console.WriteLine("");
PrintMatrix(array2D);