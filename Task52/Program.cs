// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
ArithmeticalMeanColumns(matrix);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void ArithmeticalMeanColumns(int[,] matr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avarage = (avarage + matrix[i, j]);
        }
        avarage = Math.Round(avarage / m, 1);
        Console.Write(avarage + "; ");
    }
}