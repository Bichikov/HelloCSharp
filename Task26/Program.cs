// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumLength(int num)
{
    int n = 1;
    for (int i = 0; i < 10; i++)
    {
        num = num / 10;
        if(num!= 0) n ++;
        else break;
    }
    return n;
}
int numLength = NumLength(num: number);
Console.WriteLine(numLength);