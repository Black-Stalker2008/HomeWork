// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxDigitArray(double[] array)
{
    double maxDigit = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxDigit) maxDigit = array[i];
    }
    return maxDigit;
}

double MinDigitArray(double[] array)
{
    double minDigit = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minDigit) minDigit = array[i];
    }
    return minDigit;
}

double Difference(double[] array)
{
    double result = MaxDigitArray(array) - MinDigitArray(array);
    result = Math.Round(result, 1);
    return result;
}

double[] arr = CreateArrayRndDouble(5, -10, 10);
PrintArray(arr);
double res = Difference(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {res}");

// int result = SumUnevenIndexArray(arr);
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {result}");

// int SumUnevenIndexArray(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum = sum + array[i];
//     }
//     return sum;
// }