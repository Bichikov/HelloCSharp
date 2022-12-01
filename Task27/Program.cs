// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int n)
{
    int i = 0;
    while (n > 0)
    {
        i += n % 10;
        n /= 10;
    }
    return i;
}
Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a)}");