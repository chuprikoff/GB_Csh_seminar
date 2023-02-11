// Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine()!);

if (N > M)
{
    (N, M) = (M, N);
}
Console.WriteLine($"M = {M}, N = {N}| => {myFunc(N)}");

//====================Methods=============

int myFunc(int N)
{
    while (N < M)
    {
        return N + myFunc(N + 1);
    }
    return N;
}
