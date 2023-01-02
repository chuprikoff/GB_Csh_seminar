// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое число: ");
int user_N = System.Convert.ToInt32(Console.ReadLine());
int[] num_arr = new int[user_N];
for(int i = 0; i < num_arr.Length; i++)
{
  num_arr[i] = System.Convert.ToInt32(Math.Pow((i+1),3));
}
string result_str = String.Join(", ", num_arr);
Console.WriteLine($"{user_N} -> {result_str}");