// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, в степень которого хотите возвести первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int Degree(int x, int y)
{
    int n = 1;
    for (int i = 0; i < y; i++)
    {
        n = n * x;
    }
    return n;
}
Console.WriteLine($"Число {a} в степени {b} = {Degree(a, b)}");