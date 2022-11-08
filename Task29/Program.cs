// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i<len; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i<arr.Length-1) Console.Write(",");
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
PrintArray(array);
