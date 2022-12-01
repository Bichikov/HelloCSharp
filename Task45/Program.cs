// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CopyArray (int[] arr)
{
    int [] copyArray = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr [i];
    }
    return copyArray;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int [] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
CopyArray(array);
PrintArray(CopyArray(array));