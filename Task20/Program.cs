// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите точку XA: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку YA: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку XB: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку YB: ");
double yb = Convert.ToInt32(Console.ReadLine());

double Distance(double xa, double ya, double xb, double yb)
{
    double xc = (xa -xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double result = Math.Sqrt(xc + yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);