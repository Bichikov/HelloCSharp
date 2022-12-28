// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4      1   2   3   4 
// 12 13 14 05      12  13  14  5   
// 11 16 15 06      11  16  15  6
// 10 09 08 07      10  9   8   7


void SpiralArray(int[,] array1)
{
    int num = 1; // 
    int i = 0; // 
    int j = 0; //   
    while (num <= array1.GetLength(0) * array1.GetLength(1)) //  <= 16
    {
        array1[i, j] = num;
        if (i <= j + 1 && i + j < array1.GetLength(0) - 1)
            j++;
        else if (i < j && i + j >= array1.GetLength(1) - 1)
            i++;
        else if (i >= j && i + j > array1.GetLength(0) - 1)
            j--;
        else
            
        num++;
    }
}


void PrintArray(int[,] array1)
{
for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            
            if (j < array1.GetLength(1) - 1) Console.Write($"{array1[i, j], 4}, ");
            else Console.Write($"{array1[i, j], 4} ");
            
        }
            Console.WriteLine("|");
    }

}




Console.Write("Введите кол-во строк и столбцов: ");
int rowsColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк и столбцов: ");
int rowsColumns2 = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[rowsColumns,rowsColumns2];

SpiralArray(array);
PrintArray(array);