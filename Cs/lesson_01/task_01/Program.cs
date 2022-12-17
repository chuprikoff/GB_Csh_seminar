Console.Write("Введите первое целое число: ");
int maxNum = System.Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int minNum = System.Convert.ToInt32(Console.ReadLine());
if (minNum > maxNum)
{
  maxNum = minNum;
}
Console.WriteLine(maxNum + " больше");