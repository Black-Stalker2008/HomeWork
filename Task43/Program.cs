// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double [] Crossroad(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    return new double [] {x, y};
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double [] crossroad = Crossroad(b1, k1, b2, k2);
    Console.WriteLine($"Две прямые пересекутся в точке с координатами ({crossroad[0]}, {crossroad[1]})");
}

