// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = HelixArray(rows, columns);

PrintArray(array);

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

int[,] HelixArray(int n, int m)
{
    int[,] array = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return array;
}
