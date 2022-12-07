// Задача 55

// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае если это невозможно программа должна вывести сообщение для пользователя.


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2}, ");
            else Console.Write($"{matrix[i, j], 2} ");
            
        }
            Console.WriteLine("|");
    }
}

int[,] SwapRowsColumns(int[,] matrix)
{
    int[,] temp = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j, i] = matrix[i, j];
        }
    }
    return temp;
}

void Output(int[,] matrix)
{
    if (matrix.GetLength(1) == matrix.GetLength(0))
    {
        int[,] swapArray = SwapRowsColumns(matrix);
        PrintMatrix(swapArray);
    }
    else
    {
        Console.WriteLine("Массив не квадратный, процедура не выполнима.");
    }
}

Console.Clear();

int[,] creatMatrix = CreateMatrixRndInt(4, 4, 1, 5);
PrintMatrix(creatMatrix);


Console.WriteLine("");
Console.WriteLine("");

// int[,] swapArray = SwapRowsColumns(creatMatrix);
Output(creatMatrix);




