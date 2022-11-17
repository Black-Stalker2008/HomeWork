// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите какое количество чисел вы хотите ввести: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через запятую: ");       // Например вот так: 0,1,-2,5,10
int[] numbers = CreateArrayNumbers(Console.ReadLine());
PrintArray(numbers);
int result = Sum(numbers);
Console.WriteLine($"Чисел больше 0 -> {result}");

int[] CreateArrayNumbers(string income)
{
    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < income.Length; i++)
    {
        string temp = "";

        while (income[i] != ',')
        {
            if (i != income.Length - 1)
            {
                temp += income[i].ToString();
                i++;
            }
            else
            {
                temp += income[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
