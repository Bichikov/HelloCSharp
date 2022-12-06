// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
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

int[] CreaterArif(int[,] matrix, int row, int col)
{
   int size = col;
   int[] array1 = new int[size];
   int arifmetic = 0 ;
    for (int k = 0; k < size; k++)
    {  
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                arifmetic = matrix[i, j] + arifmetic;
            }
            array1[k] = arifmetic;
        }  
    }
    return array1;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Console.Clear();

Console.Write("Введите кол-во строк для массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов для массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows ,columns ,1, 4);
PrintMatrix(array);

Console.WriteLine("");

int[] arrayArif = CreaterArif(array, rows, columns);
Console.Write($"Cреднее арифметическое каждого стобца = ");
PrintArray(arrayArif);



