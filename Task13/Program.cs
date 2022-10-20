// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{
    int rem = -1;
    while (number % 1000 >= 100)
    {
        rem = number % 10;
        number = number / 10;
    }
    return rem;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int remain = ThirdDigit(num);
System.Console.WriteLine(remain >= 0 ? $"Третья цифра: {remain}" : "Третьей цифры нет");

