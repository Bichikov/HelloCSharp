Console.WriteLine("Введите трехзначное число число");
int num1 = Convert.ToInt32(Console.ReadLine());
string showNumber(int num)
{
    if (num > 99 && num < 1000)
    {
        int second = (num % 100 - num % 10) / 10;
        return ("Вторая цифра числа -> " + second);
    }
    else
    {
        return "Введенное число не трехзначное!";
    }
}
Console.WriteLine(showNumber(num1));