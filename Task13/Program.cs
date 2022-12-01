Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string showNumber(int num)
{
    int i = 0;
    int n = num;
    if (n < 100)
    {
        return ("Третья цифра в числе отсутствует");
    }
    else
    {
        while (n > 999)
        {
            n = n / 10;
            i++;
        }

        int third = n % 10;
        return ("Третья цифра числа -> " + third);
    }
}
Console.WriteLine(showNumber(num1));