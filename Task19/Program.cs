// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrom(int number)
{
    return number / 10000 == number % 10 && 
    number / 1000 % 10 == number % 100 / 10;
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

if (num <= 10000 || num > 99999)
{
    Console.WriteLine("Введённое число не является пятизначным");
}
else
{
    bool palindrom = Palindrom(num);
    Console.WriteLine("Является ли оно палиндромом?");
    Console.WriteLine(palindrom ? "Да" : "Нет");
}


