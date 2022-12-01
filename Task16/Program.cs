// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Sqr(int numb1, int numb2)
{
    return numb1 == numb2 * numb2 || numb2 == numb1 * numb1;
}
Console.WriteLine("Является ли одно число квадратом второго?");
string result = Sqr(number1, number2) ? "да" : "нет";
Console.WriteLine(result);