// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] СompositionMatrix(int[,]arr, int[,]arr2)
{
int rA = arr.GetLength(0);
int cA = arr.GetLength(1);
int rB = arr2.GetLength(0);
int cB = arr2.GetLength(1);

int[,] composMatrix = new int[rA, cB];

    for (int j = 0; j < composMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < composMatrix.GetLength(0); i++)
        {
            for (int k = 0; k < cA ; k++)
            {
                composMatrix[i,j] += arr[i,k] * arr2[k,j] ;  
            }
        }   
    }
    return composMatrix;
}



Console.WriteLine("Первая матрица: ");
int[,] array2D = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
Console.WriteLine("Вторая матрица: ");
int[,] array2D2 = CreateMatrixRndInt(3, 1, 1, 10);
PrintMatrix(array2D2);
Console.WriteLine("");
 if (array2D.GetLength(1) != array2D2.GetLength(0))
        {
            Console.WriteLine("Матрицы невозможно перемножить! ! !");
        }
else 
{
Console.WriteLine("Произведение матриц: ");
int[,] array2D3 = СompositionMatrix(array2D,array2D2);
PrintMatrix(array2D3);
}



