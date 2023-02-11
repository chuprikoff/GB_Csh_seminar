// Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

//====================Methods================


string PrintNumbers(int start, int finish)
{
    if (start == finish)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbers(start - 1, finish));
}