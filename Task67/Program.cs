// Задача 67

// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int numb)
{
    if (numb != 0)

        return numb % 10 + SumDigits(numb / 10);

    return 0;
}
Console.WriteLine(SumDigits(Math.Abs(number)));