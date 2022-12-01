Console.WriteLine("Введите число дня недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay == 1)
    Console.WriteLine("Понедельник");

else if (numDay == 2)
    Console.WriteLine("Вторник");

else if (numDay == 3)
    Console.WriteLine("Среда");

else if (numDay == 4)
    Console.WriteLine("Четверг");

else if (numDay == 5)
    Console.WriteLine("Пятница");

else if (numDay == 6)
    Console.WriteLine("Суббота");

else if (numDay == 7)
    Console.WriteLine("Воскресение");

else if (numDay >= 8)
    Console.WriteLine("Такого дня недели не существует");
