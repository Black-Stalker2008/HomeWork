// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplyMatrix(int[,] matrix, int[,] table, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int temp = 0;
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        temp += matrix[i,k] * table[k,j];
      }
      resultMatrix[i,j] = temp;
    }
  }
}

Console.Write("Введите количество строк массива первой матрицы: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива первой матрицы: n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк массива второй матрицы: a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива второй матрицы: b = ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] table = CreateMatrixRndInt(a, b, 0, 9);
PrintMatrix(table);
int[,] resultMatrix = new int[m,b];

if (matrix.GetLength(1) != table.GetLength(0))
{
    Console.WriteLine("Нельзя перемножить");
    return;
}

MultiplyMatrix(matrix, table, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);


