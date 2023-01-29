// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -99, 100);
PrintArray(array);
Console.WriteLine();
MyPrintArray(array);

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10) Console.Write($"  {array[i, j]} |");
            else if
                ((array[i, j] < 0 && array[i, j] > -10)
                || (array[i, j] > 9 && array[i, j] < 100))
            {
                Console.Write($" {array[i, j]} |");
            }
            else Console.Write($"{array[i, j]} |");
        }
        Console.WriteLine();
    }
}
void MyPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[j, i] >= 0 && array[j, i] < 10) Console.Write($"  {array[j, i]} |");
            else if
                ((array[j, i] < 0 && array[j, i] > -10)
                || (array[j, i] > 9 && array[j, i] < 100))
            {
                Console.Write($" {array[j, i]} |");
            }
            else Console.Write($"{array[j, i]} |");
            sum += array[j, i];
        }
        Console.WriteLine($" -> {Math.Round((sum / rows), 2)}");
    }
}

