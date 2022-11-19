// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите количество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс строки: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
FindElement(matrix, line, colmns);

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

void FindElement(int[,] matr, int line, int colmns)
{
    if (line < matrix.GetLength(0) && colmns < matrix.GetLength(1)) 
    Console.WriteLine($"Элемент с такими индексами строки и столбца -> {matrix[line, colmns]}");
    else 
    Console.WriteLine($"{line}, {colmns} -> Элемента с такими индексами строки и столбца в массиве нет");
}