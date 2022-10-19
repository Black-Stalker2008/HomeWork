// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondDigit(int number)
{
    return number = number / 10 % 10;
}

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 100 | num > 999)
{
    Console.WriteLine("Введённое число не является трехзначным");
}
else
{
    Console.WriteLine($"Вторая цифра этого числа: {SecondDigit(num)}");
} 
