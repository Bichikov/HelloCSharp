//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
Console.WriteLine($"Число {num1} является максимальным, а число {num2} минимальным");
}
else  Console.WriteLine($"Число {num2} является максимальным, а число {num1} минимальным");