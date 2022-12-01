// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] arr)
{
    int l = arr.Length;
    for (int j = 0; j < l; j++)
    {
        Console.Write(arr[j] + " ");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);