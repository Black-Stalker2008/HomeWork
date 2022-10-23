// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int n)
{
    if (n > 0)
    {
        int index = 1;
        Console.WriteLine($"Таблица кубов числео от 1 до {n}:");
        while (index <= n)
        {
            Console.WriteLine("----------");
            Console.WriteLine($"{index,3} | {Math.Pow(index, 3),4}");
            index++;
        }

    } 
    else Console.WriteLine("Некорректное число");
}


Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);