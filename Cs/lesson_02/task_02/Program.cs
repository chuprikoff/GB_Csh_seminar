// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Берем числа до 100000


Console.WriteLine("Введите число: ");
string UserInput = Console.ReadLine();

if (UserInput.Length<3)
{
  Console.WriteLine($"{UserInput} -> третьей цифры нет");
}
else
{
  Console.WriteLine($"{UserInput} -> {UserInput[2]}");
}
