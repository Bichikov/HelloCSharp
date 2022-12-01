// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string Binary(int number)
{
    string bin = "";
    while (number > 0)
    {
        bin = number % 2 + bin;
        number /= 2;
    }
    return bin;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Binary(number));