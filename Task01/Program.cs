Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{

    Console.WriteLine($"Да, число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Нет, число {a} не является квадратом числа {b}");
}