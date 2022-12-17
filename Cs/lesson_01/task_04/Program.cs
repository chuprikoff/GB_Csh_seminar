Console.Write("Введите целое число: ");
int num = System.Convert.ToInt32(Console.ReadLine());
int num1 = 1;
while (num1<=num)
{
  if (num1%2==0)
  {
    Console.Write($"{num1}, ");
  }
  num1++;
}