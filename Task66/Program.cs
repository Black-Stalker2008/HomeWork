// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());


int NaturalNambersSum(int num1, int num2)
{
    if (num1 == num2)
        return num2;
    if (num2 > num1)
        return num2 + NaturalNambersSum(num1, num2 - 1);
    return num1 + NaturalNambersSum(num2, num1 - 1);
}

if (numberM == numberN)
    Console.WriteLine($"Сумма элементов от {numberM} до {numberN} = {numberN}");
else
    Console.WriteLine($"Сумма элементов от {numberM} до {numberN} = {NaturalNambersSum(numberM, numberN)}");
