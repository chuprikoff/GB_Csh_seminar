// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка



Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -99, 100);
PrintArray(array);
int[] SumsRows = SumRowArray(array);
int indexMinSumsRows = GetIndexArray(SumsRows);
Console.Write($"Наименьшая сумма элементов в строке номер {indexMinSumsRows}");



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

int[] SumRowArray(int[,] array)
{
    int[] result = new int[rows];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        int sumRow = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sumRow += array[j, k];
        }
        result[j] = sumRow;
    }
    return result;
}

int GetIndexArray(int[] array)
{
    int minValue = array.Min();
    int indexMin = Array.IndexOf(array, minValue);
    return indexMin + 1;
}