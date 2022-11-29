// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа num1 и num2.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(numberM, numberN);

void AkkermanFunction(int numberM, int numberN)
{
    Console.Write($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");
}

int Akkerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num1 > 0 && num2 == 0)
    {
        return Akkerman(num1 - 1, 1);
    }
    else
    {
        return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
    }
}

