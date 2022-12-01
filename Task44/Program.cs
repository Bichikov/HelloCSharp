// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci (int num)
{
    int [] fibonacci = new int[num];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for(int i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i -2];
    }
    return fibonacci;
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


Console.WriteLine("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] fibonacci = Fibonacci(number);
PrintArray(fibonacci);