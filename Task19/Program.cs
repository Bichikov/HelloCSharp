// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
string Palindrome(int n)
{
    if (n < 10000 ^ n > 99999)
    {
        return "Число не является пятизначным!";
    }
    else if (n / 10000 == n % 10 && (n / 1000) % 10 == (n / 10) % 10)
    {
        return "Палиндром";
    }
    else
    {
        return "Не палиндром";
    }
}
Console.WriteLine(Palindrome(n1));