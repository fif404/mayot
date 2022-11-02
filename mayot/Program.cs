// Скрипников Сергей 17 вариант 2.3
Console.WriteLine("Ввеите x1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ввеите y1:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ввеите x2:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ввеите y2:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ввеите x3:");
double x3 = double.Parse(Console.ReadLine());
Console.WriteLine("Ввеите y3:");
double y3 = double.Parse(Console.ReadLine());
if ((x1 == 9) && (y1 == 2) || (x2 == 7) && (y2 == 3) || (x3 == 0.1) && (y3 == 4))
    Console.WriteLine("точки лежат в первой части");
else
    Console.WriteLine("точки не лежат в первой части");