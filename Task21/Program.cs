// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return Math.Round(distance,2,MidpointRounding.ToZero);
}

Console.Write("Введите X координату точки A:");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A:");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки A:");
int z1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X координату точки B:");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B:");
int y2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки B:");
int z2=Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) равно {distance}");

