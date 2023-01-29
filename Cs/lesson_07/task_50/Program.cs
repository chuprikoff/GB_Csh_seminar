// Напишите программу, которая на вход принимает число, проверяя есть ли такое 
// число в двумерном массиве и возвращает сообщение о том, что оно найдено или же 
// указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
//=================================================================

Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(4, 4, -20, 20);
PrintArray(array);
ElemIsArray(array);






//===================methods===============

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

void ElemIsArray(int[,] array)
{
    bool res = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == userNumber)
            {
                res = true;
                break;
            };
        }
    }
    if (res) Console.Write($"{userNumber} => число найдено в массиве!");
    else Console.Write($"{userNumber} => такого числа в массиве нет!");


}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

