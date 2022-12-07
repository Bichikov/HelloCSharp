// Залача 59
// Задайте двумерный массив из целых чисел.
// Напишите программу которая удалит строку и столбец на 
// пересечении которых расположен наименьший эллемент массива. 


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Создаем двумерный массив
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

void PrintMatrix(int[,] matrix) // печатаем двумерный массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("\n[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
            Console.Write((j < matrix.GetLength(1) - 1) ? "," : string.Empty);
        }
        Console.Write(" ]");
    }
}

int[] MinElement(int[,] arr) // на ходим позицию минимального элемента по индексу
{
    int[] array = new int[2];
    int minimum = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < minimum) 
            {
                minimum = arr[i,j];
                array[0] = i;
                array[1] = j;
            }
            
        }
    }
    return array;
}

void PrintArray(int[] arr) // печатаем минимальное значение (индексы)
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

int[,] CreateMatrixRndInt2(int[] arr, int[,] array) // делаем новый массив по условию задачи
{
    int rows = array.GetLength(0)-1;
    int columns = array.GetLength(1)-1;
    int[,]matrix2 = new int[rows, columns];
    for (int i = 0, m = 0; i < rows; i++, m++) 
    {
        if (m == arr[0]) m++; // пропускаем строку из первого массива по условию задачи
            for (int j = 0, n = 0; j < columns; j++, n++) 
            {
                if (n == arr[1]) n++; // пропускаем стобец из первого массива по условию задачи
                matrix2[i,j] = array[m, n];
                n++;
            }
    }
    return matrix2;
}



int[,] array2D = CreateMatrixRndInt(4, 5, 1, 100);
PrintMatrix(array2D);
Console.WriteLine();
Console.WriteLine();
int[] minimumElement = MinElement(array2D);
PrintArray(minimumElement);
int[,] array3D = CreateMatrixRndInt2(minimumElement, array2D);
PrintMatrix(array3D);

