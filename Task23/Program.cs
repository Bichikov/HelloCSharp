// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
void cube(int num)
{
    int i = 1;
    while (i <= num)
    {

     Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
cube(Num);