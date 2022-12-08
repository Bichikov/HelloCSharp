// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] arr(int[,] matrix)
{
    int sum = 0;
    int k = 0;
    int[] array1 = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = matrix[i,j] + sum;
        }
        array1[k] = sum;
        sum = 0;
        k++;
    }
    return array1;
}

void MinSum (int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]< min)
        { 
            min = arr[i]; 
            index = i+1; // +1 для читабельности пользователю. (чтобы не было с первой страки "0")
        }
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов = {index}");
}

int[,] array2D = CreateMatrixRndInt(3, 2, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
int[] array = arr(array2D);
MinSum(array);


