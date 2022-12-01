Console.WriteLine("Введите число от 1 до 7, соответствующее дню недели: ");
int n = Convert.ToInt32(Console.ReadLine());
string dayWeek(int n)
{
    if (n > 5 && n < 8)
    {
    return ("Это выходной!");
    }

else if (n > 0 && n < 6 )
{
    return ("Это будний день!");
}

else 
{
    return ("Такого дня недели не существует!");
}
}
Console.WriteLine(dayWeek(n));