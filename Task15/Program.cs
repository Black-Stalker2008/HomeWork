// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekends(int number)
{
    return number == 6 || number == 7;
}
Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0 | num >= 8)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    bool weekends = Weekends(num);
    Console.WriteLine("Этот день недели выходной?");
    Console.WriteLine(weekends ? "Да" : "Нет");
} 


