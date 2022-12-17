Console.Write("Введите целое число: ");
int num = System.Convert.ToInt32(Console.ReadLine());
string myStr = "Нет";
if (num % 2 == 0)
{
  myStr = "Да";
}
Console.WriteLine(myStr);