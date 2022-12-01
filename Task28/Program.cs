// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int factorial(int number)
{
    if (number == 1)
    {
        return 1;
    }
    return number * factorial(number - 1);
}

Console.WriteLine(factorial(N));